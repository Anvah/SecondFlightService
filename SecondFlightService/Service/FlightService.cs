﻿using SecondFlightService.Models;
using SecondFlightService.Models.Enums;
using SecondFlightService.Service.Interfaces;

namespace SecondFlightService.Service
{
    public class FlightService: IFlightService
    {
        private static List<Flight> secondFlights = new List<Flight>
            {
                new Flight
                {
                    Id = "SU123",
                    Airline = "Aeroflot",
                    DepartureAirport = "SVO",
                    DepartureCity = "Moscow",
                    DepartureCountry = "Russia",
                    ArrivalAirport = "CDG",
                    ArrivalCity = "Paris",
                    ArrivalCountry = "France",
                    DepartureTime = "2024-03-16 09:00",
                    ArrivalTime = "2024-03-16 15:30",
                    Transfres = new string[] { "Frankfurt Frankfurt Frankfurt" },
                    TransfersArivalDateTime = new string[] { "2024-03-16 11:30" },
                    TransfersDepartureDateTime = new string[] { "2024-03-16 12:30" },
                    Price = 300.50m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 25.00m
                },
                new Flight
                {
                    Id = "DL456",
                    Airline = "Delta Airlines",
                    DepartureAirport = "JFK",
                    DepartureCity = "New York",
                    DepartureCountry = "USA",
                    ArrivalAirport = "LAX",
                    ArrivalCity = "Los Angeles",
                    ArrivalCountry = "USA",
                    DepartureTime = "2024-03-16 08:30",
                    ArrivalTime = "2024-03-16 11:00",
                    Transfres = Array.Empty<string>(),
                    TransfersArivalDateTime = Array.Empty<string>(),
                    TransfersDepartureDateTime = Array.Empty<string>(),
                    Price = 200.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 20.00m
                },
                new Flight
                {
                    Id = "BA789",
                    Airline = "British Airways",
                    DepartureAirport = "LHR",
                    DepartureCity = "London",
                    DepartureCountry = "UK",
                    ArrivalAirport = "HND",
                    ArrivalCity = "Tokyo",
                    ArrivalCountry = "Japan",
                    DepartureTime = "2024-03-16",
                    ArrivalTime = "2024-03-17 08:00",
                    Transfres = new string[] { "Amsterdam Amsterdam Amsterdam", "Singapore Singapore Singapore" },
                    TransfersArivalDateTime = new string[] { "2024-03-16 13:30", "2024-03-17 02:30" },
                    TransfersDepartureDateTime = new string[] { "2024-03-16 14:30", "2024-03-17 04:30" },
                    Price = 500.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 30.00m
                },
                new Flight
                {
                    Id = "CA101",
                    Airline = "Air China",
                    DepartureAirport = "PEK",
                    DepartureCity = "Beijing",
                    DepartureCountry = "China",
                    ArrivalAirport = "PVG",
                    ArrivalCity = "Shanghai",
                    ArrivalCountry = "China",
                    DepartureTime = "2024-03-16 12:00",
                    ArrivalTime = "2024-03-16 14:30",
                    Transfres = Array.Empty<string>(),
                    TransfersArivalDateTime = Array.Empty<string>(),
                    TransfersDepartureDateTime = Array.Empty<string>(),
                    Price = 150.00m,
                    IsBaggageAvaible = false,
                    BaggagePrice = 0.00m
                },
                new Flight
                {
                    Id = "QF321",
                    Airline = "Qantas Airways",
                    DepartureAirport = "SYD",
                    DepartureCity = "Sydney",
                    DepartureCountry = "Australia",
                    ArrivalAirport = "MEL",
                    ArrivalCity = "Melbourne",
                    ArrivalCountry = "Australia",
                    DepartureTime = "2024-03-16 07:30",
                    ArrivalTime = "2024-03-16 10:00",
                    Transfres = new string[] { "Canberra Canberra Canberra" },
                    TransfersArivalDateTime = new string[] { "2024-03-16 08:30" },
                    TransfersDepartureDateTime = new string[] { "2024-03-16 09:00" },
                    Price = 180.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 15.00m
                },
                new Flight
                {
                    Id = "IB567",
                    Airline = "Iberia",
                    DepartureAirport = "FCO",
                    DepartureCity = "Rome",
                    DepartureCountry = "Italy",
                    ArrivalAirport = "MAD",
                    ArrivalCity = "Madrid",
                    ArrivalCountry = "Spain",
                    DepartureTime = "2024-03-16 11:00",
                    ArrivalTime = "2024-03-16 14:00",
                    Transfres = Array.Empty<string>(),
                    TransfersArivalDateTime = Array.Empty<string>(),
                    TransfersDepartureDateTime = Array.Empty<string>(),
                    Price = 220.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 25.00m
                },
                new Flight
                {
                    Id = "LH654",
                    Airline = "Lufthansa",
                    DepartureAirport = "TXL",
                    DepartureCity = "Berlin",
                    DepartureCountry = "Germany",
                    ArrivalAirport = "MUC",
                    ArrivalCity = "Munich",
                    ArrivalCountry = "Germany",
                    DepartureTime = "2024-03-16 11:00",
                    ArrivalTime = "2024-03-16 14:00",
                    Transfres = new string[] { "Frankfurt Frankfurt Frankfurt" },
                    TransfersArivalDateTime = new string[] { "2024-03-16 08:30" },
                    TransfersDepartureDateTime = new string[] { "2024-03-16 08:30" },
                    Price = 120.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 20.00m
                },
                new Flight
                {
                    Id = "IB987",
                    Airline = "Iberia",
                    DepartureAirport = "FCO",
                    DepartureCity = "Rome",
                    DepartureCountry = "Italy",
                    ArrivalAirport = "MAD",
                    ArrivalCity = "Madrid",
                    ArrivalCountry = "Spain",
                    DepartureTime = "2024-03-16 11:00",
                    ArrivalTime = "2024-03-16 14:00",
                    Transfres = new string[0],
                    TransfersArivalDateTime = new string[0],
                    TransfersDepartureDateTime = new string[0],
                    Price = 220.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 25.00m
                },
                new Flight
                {
                    Id = "EK753",
                    Airline = "Emirates",
                    DepartureAirport = "DXB",
                    DepartureCity = "Dubai",
                    DepartureCountry = "UAE",
                    ArrivalAirport = "DEL",
                    ArrivalCity = "Delhi",
                    ArrivalCountry = "India",
                    DepartureTime = "2024-03-16 11:00",
                    ArrivalTime = "2024-03-16 14:00",
                    Transfres = new string[] { "Mumbai Mumbai Mumbai" },
                    TransfersArivalDateTime = new string[] { "2024-03-16 08:30" },
                    TransfersDepartureDateTime = new string[] { "2024-03-16 08:30" },
                    Price = 280.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 30.00m
                },
                new Flight
                {
                    Id = "KE888",
                    Airline = "Korean Air",
                    DepartureAirport = "ICN",
                    DepartureCity = "Seoul",
                    DepartureCountry = "South Korea",
                    ArrivalAirport = "HKG",
                    ArrivalCity = "Hong Kong",
                    ArrivalCountry = "China",
                    DepartureTime = "2024-03-17 11:00",
                    ArrivalTime = "2024-03-16 14:00",
                    Transfres = new string[0],
                    TransfersArivalDateTime = new string[0],
                    TransfersDepartureDateTime = new string[0],
                    Price = 200.00m,
                    IsBaggageAvaible = true,
                    BaggagePrice = 25.00m
                }
            };
        async public Task<Flight> Book(string Id)
        {
            var flight = secondFlights.FirstOrDefault(f => f.Id == Id);
            if (flight != null)
            {
                if (!flight.IsBooked)
                {
                    flight.IsBooked = true;
                    return flight;
                }
                
            }
            return null;

        }
        public async Task<IEnumerable<Flight>> GetFlights(DateTime? date, SortProperty sortProperty = SortProperty.ByPrice, decimal maxPrice = decimal.MaxValue)
        {
            var sortedFlight = secondFlights
                .Where(f => (date == null || DateTime.Parse(f.DepartureTime).Date == date?.Date)
                && f.Price < maxPrice)
                .OrderBy(f => sortProperty == SortProperty.ByPrice ? f.Price : f.Transfres.Count());
            return sortedFlight;
        }
    }
}
