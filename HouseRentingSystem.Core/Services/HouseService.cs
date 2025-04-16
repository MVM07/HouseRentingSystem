using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Enumeration;
using HouseRentingSystem.Core.Exceptions;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services
{
    public class HouseService : IHouseService
    {
        private readonly IRepository repository;

        public HouseService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<HouseQueryServiceModel> AllAsync(string? category = null, 
            string? searchTerm = null,
            HouseSorting sorting = HouseSorting.Newest,
            int currentPage = 1,
            int housesPerPage = 1)
        {
            var housesToShow = repository.AllReadOnlyAsync<House>()
                .Where(h => h.IsApproved == true);

            if (category != null)
            {
                housesToShow = housesToShow
                    .Where(h => h.Category.Name == category);
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();

                housesToShow = housesToShow
                    .Where(h => (h.Title.ToLower().Contains(normalizedSearchTerm) ||
                    h.Address.ToLower().Contains(normalizedSearchTerm) ||
                    h.Description.ToLower().Contains(normalizedSearchTerm)));
            }

            housesToShow = sorting switch
            {
                HouseSorting.Price => housesToShow.OrderBy(h => h.PricePerMonth),
                HouseSorting.NotRentedFirst => housesToShow.OrderBy(h => h.RenterId != null)
                .ThenByDescending(h => h.Id),
                _ => housesToShow.OrderByDescending(h => h.Id)
            };

            var houses = await housesToShow
                .Skip((currentPage - 1) * housesPerPage)
                .Take(housesPerPage)
                .ProjectToHouseServiceModel()
                .ToListAsync();

            int totalHouses = await housesToShow.CountAsync();

            return new HouseQueryServiceModel()
            {
                Houses = houses,
                TotalHousesCount = totalHouses,
            };
        }

        public async Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync()
        {
            var categories = await repository.AllReadOnlyAsync<Category>()
                .Select(c => new HouseCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();

            return categories;
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository.AllReadOnlyAsync<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<HouseServiceModel>> AllHousesByAgentIdAsync(int agentId)
        {
            var agent = await repository.AllReadOnlyAsync<House>()
                .Where(h => h.AgentId == agentId && h.IsApproved == true)
                .ProjectToHouseServiceModel()
                .ToListAsync();

            return agent;
        }

        public async Task<IEnumerable<HouseServiceModel>> AllHousesByUserIdAsync(string userId)
        {
            var user = await repository.AllReadOnlyAsync<House>()
                .Where(h => h.RenterId == userId && h.IsApproved == true)
                .ProjectToHouseServiceModel()
                .ToListAsync();

            return user;
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            var category = await repository.AllReadOnlyAsync<Category>()
                .AnyAsync(c => c.Id == categoryId);

            return category;
        }

        public async Task<int> CreateAsync(HouseFormModel model, int agentId)
        {
            House house = new House()
            {
                Title = model.Title,    
                Description = model.Description,
                PricePerMonth = model.PricePerMonth,
                CategoryId = model.CategoryId,
                Address = model.Address,
                AgentId = agentId,
                ImageUrl = model.ImageUrl
            };

            await repository.AddAsync(house);
            await repository.SaveChangesAsync();

            return house.Id;
        }

        public async Task DeleteAsync(int houseId)
        {
            await repository.DeleteAsync<House>(houseId);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(int houseId, HouseFormModel model)
        {
            var house = await repository.GetByIdAsync<House>(houseId);

            if (house != null)
            {
                house.Address = model.Address;
                house.ImageUrl = model.ImageUrl;
                house.PricePerMonth = model.PricePerMonth;
                house.CategoryId = model.CategoryId;
                house.Description = model.Description;
                house.Title = model.Title;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnlyAsync<House>()
                .AnyAsync(h => h.Id == id);
        }

        public async Task<HouseFormModel?> GetHouseFormModelByIdAsync(int id)
        {
            var house = await repository.AllReadOnlyAsync<House>()
                 .Where(h => h.Id == id)
                 .Select(h => new HouseFormModel()
                 {
                     Address = h.Address,
                     CategoryId = h.CategoryId,
                     Title = h.Title,   
                     Description = h.Description,
                     ImageUrl = h.ImageUrl,
                     PricePerMonth = h.PricePerMonth
                 })
                 .FirstOrDefaultAsync();

            if (house != null)
            {
                house.Categories = await AllCategoriesAsync();
            }            

            return house;
        }

        public async Task<bool> HasAgentWithIdAsync(int houseId, string userId)
        {
            return await repository.AllReadOnlyAsync<House>()
                .AnyAsync(h => h.Id == houseId && h.Agent.UserId == userId);
        }

        public async Task<HouseDetailsServiceModel> HouseDetailsByIdAsync(int id)
        {
            return await repository.AllReadOnlyAsync<House>()
                .Where(h => h.Id == id)
                .Select(h => new HouseDetailsServiceModel()
                {
                    Id = h.Id,
                    Title = h.Title,
                    Address = h.Address,
                    Agent = new Models.Agent.AgentServiceModel()
                    {
                        FullName = $"{h.Agent.User.Firstname} {h.Agent.User.Lastname}",
                        Email = h.Agent.User.Email,
                        PhoneNumber = h.Agent.PhoneNumber
                    },
                    Category = h.Category.Name,
                    Description = h.Description,
                    PricePerMonth = h.PricePerMonth,
                    ImageUrl = h.ImageUrl,
                    IsRented = h.RenterId != null
                })
                .FirstAsync();
        }

        public async Task<bool> IsRentedAsync(int houseId)
        {
            bool result = false;

            var house = await repository.GetByIdAsync<House>(houseId);

            if (house == null)
            {
                result = house.RenterId != null;
            }

            return result;
        }

        public async Task<bool> IsRentedByUserWithIdAsync(int houseId, string userId)
        {
            bool result = false;

            var house = await repository.GetByIdAsync<House>(houseId);

            if (house != null)
            {
                result = house.RenterId == userId;
            }

            return result;
        }

        public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync()
        {
            var houses = await repository
                .AllReadOnlyAsync<House>()
                .Where(h => h.IsApproved == true)
                .OrderByDescending(h => h.Id)
                .Take(3)
                .Select(h => new HouseIndexServiceModel()
                {
                    Id = h.Id,
                    Title = h.Title,
                    ImageUrl = h.ImageUrl,
                    Address = h.Address
                })
                .ToListAsync();

            return houses;
        }

        public async Task LeaveAsync(int houseId, string userId)
        {
            var house = await repository.GetByIdAsync<House>(houseId);

            if (house != null)
            {
                if (house.RenterId != userId)
                {
                    throw new UnauthorizedActionException("The user is not the renter.");
                }

                house.RenterId = null;
                await repository.SaveChangesAsync();
            }
        }

        public async Task RentAsync(int houseId, string userId)
        {
            var house = await repository.GetByIdAsync<House>(houseId);

            if (house != null)
            {
                house.RenterId = userId;
                await repository.SaveChangesAsync();
            }
        }
    }
}
