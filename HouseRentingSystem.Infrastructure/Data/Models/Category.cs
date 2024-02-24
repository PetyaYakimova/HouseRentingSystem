using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
	[Comment("House category")]
	public class Category
	{
		[Key]
		[Comment("Category Identifier")]
		public int Id { get; init; }

		[Required]
		[MaxLength(CategoryNameMaxLength)]
		[Comment("Category Name")]
		public string Name { get; set; } = string.Empty;

		public IEnumerable<House> Houses { get; init; } = new List<House>();
	}
}
