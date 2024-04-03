using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
	[Comment("House to rent")]
	public class House
	{
		[Key]
		[Comment("House Identifier")]
		public int Id { get; set; }

		[Required]
		[StringLength(HouseTitleMaxLength)]
		[Comment("House Title")]
		public string Title { get; set; } = string.Empty;

		[Required]
		[StringLength(HouseAddressMaxLength)]
		[Comment("House Address")]
		public string Address { get; set; } = string.Empty;

		[Required]
		[StringLength(HouseDescriptionMaxLength)]
		[Comment("House Description")]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Comment("House Image URL")]
		public string ImageUrl { get; set; } = string.Empty;

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		[Comment("House Price per Month")]
		//[Range(typeof(decimal), HousePricePerMonthMin, HousePricePerMonthMax, ConvertValueInInvariantCulture = true)]
		public decimal PricePerMonth { get; set; }

		[Required]
		[Comment("Category Identifier")]
		public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; } = null!;

		[Required]
		[Comment("Agnet Identifier")]
		public int AgentId { get; set; }

		[ForeignKey(nameof(AgentId))]
		public Agent Agent { get; set; } = null!;

		[Comment("User identifier of the renter")]
		public string? RenterId { get; set; }

		[Comment("Is house approved by admin")]
		public bool IsApproved { get; set; }
	}
}
