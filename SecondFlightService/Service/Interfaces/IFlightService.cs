using SecondFlightService.Models.Enums;
using SecondFlightService.Models;

namespace SecondFlightService.Service.Interfaces
{
    public interface IFlightService
    {
        Task<Flight> Book(string Id);
        Task<IEnumerable<Flight>> GetFlights(DateTime? date, SortProperty sortProperty = SortProperty.ByPrice, decimal maxPrice = decimal.MaxValue);
    }
}
