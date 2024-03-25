using HouseRentingSystem.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseFormModel : IHouseModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(HouseTitleMaxLength,
            MinimumLength = HouseTitleMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(HouseAddressMaxLength,
            MinimumLength = HouseAddressMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(HouseDescriptionMaxLength,
            MinimumLength = HouseDescriptionMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(typeof(decimal), 
            HousePricePerMonthMin, 
            HousePricePerMonthMax,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = PriceErrorMessage)]
        [Display(Name = "Pricer Per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = new List<HouseCategoryServiceModel>();
    }
}
