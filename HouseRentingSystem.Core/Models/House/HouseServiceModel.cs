using HouseRentingSystem.Infrastructure.Data.Constants;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Data.Constants.DataConstants;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseServiceModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(HouseTitleMaxLength, MinimumLength = HouseTitleMinLength)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(HouseAddressMaxLength, MinimumLength = HouseAddressMinLength)]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "Image URL")]
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Display(Name = "Price per month")]
        [Required]
        [Range(typeof(decimal), DataConstants.HouseRentMinValue, DataConstants.HouseRentMaxValue,
            ConvertValueInInvariantCulture = true, ErrorMessage = AllowedRentRange)]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Is Rented")]
        [Required]
        public bool IsRented { get; set; }
    }
}