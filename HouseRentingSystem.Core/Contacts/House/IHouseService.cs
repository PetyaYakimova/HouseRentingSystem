using HouseRentingSystem.Core.Models.Home;

namespace HouseRentingSystem.Core.Contacts.House
{
    public interface IHouseService
	{
		Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
	}
}
