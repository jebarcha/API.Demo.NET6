using HotelListing.API.Core.Models;
using HotelListing.API.Data;

namespace HotelListing.API.Core.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
