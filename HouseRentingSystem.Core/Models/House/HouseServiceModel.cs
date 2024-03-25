using HouseRentingSystem.Core.Contracts;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseServiceModel : IHouseModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(HouseTitleMaxLength,
           MinimumLength = HouseTitleMinLength,
           ErrorMessage = LengthErrorMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(HouseAddressMaxLength,
            MinimumLength = HouseAddressMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Range(typeof(decimal),
            HousePricePerMonthMin,
            HousePricePerMonthMax,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = PriceErrorMessage)]
        [Display(Name = "Price Per Month")]
        public decimal PricePerMonth { get; set; }

        [Display(Name = "Is Rented")]
        public bool IsRented { get; set; }
    }
}