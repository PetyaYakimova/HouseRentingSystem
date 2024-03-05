using HouseRentingSystem.Core.Models.Home;

namespace HouseRentingSystem.Core.Contacts
{
    public interface IHouseService
    {
        Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
    }
}
