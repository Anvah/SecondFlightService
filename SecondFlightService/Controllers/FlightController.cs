using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SecondFlightService.Models;
using SecondFlightService.Models.Enums;
using SecondFlightService.Service.Interfaces;

namespace SecondFlightService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("/getFlights")]
        public async Task<IEnumerable<Flight>> GetFlights([FromQuery] DateTime? date, [FromQuery] SortProperty sortProperty = SortProperty.ByPrice, [FromQuery] decimal maxPrice = decimal.MaxValue)
        {
            return await _flightService.GetFlights(date, sortProperty);
        }
        [HttpPost("/bookFlight/{id}")]
        public async Task<Flight> Book(string id)
        {
            return await _flightService.Book(id);
        }
    }
}
