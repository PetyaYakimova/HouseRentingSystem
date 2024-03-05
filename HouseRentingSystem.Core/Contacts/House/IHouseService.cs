using HouseRentingSystem.Core.Models.House;

namespace HouseRentingSystem.Core.Contacts.House
{
	public interface IHouseService
	{
		Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync();
	}
}
