using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Data.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
    [Comment("House to rent")]
    public class House
    {
        [Comment("House identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("House name")]
        [Required]
        [MaxLength(HouseTitleMaxLength)]
        public string Title { get; set; } = string.Empty;

        [Comment("House address")]
        [Required]
        [MaxLength(HouseAddressMaxLength)]
        public string Address { get; set; } = string.Empty;

        [Comment("House description")]
        [Required]
        [MaxLength(HouseDescriptionMaxLength)]
        public string Description { get; set; } = string.Empty;

        [Comment("House photo")]
        [Required]
        public string ImageUrl { get; set; } = string.Empty;

        [Comment("House rent")]
        [Required]
        [Precision(18, 2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }

        [ForeignKey(nameof(AgentId))]
        public Agent Agent { get; set; } = null!;

        [Comment("User Id of the renter")]
        public string? RenterId { get; set; } = string.Empty;
    }
}