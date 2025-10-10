using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class TripDetailsDTO
    {
        public int TripPartId { get; set; }
        public int TripId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string BusType { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public int TravelTime { get; set; }
        public decimal FareAmount { get; set; }
        public int AvailableSeats { get; set; }
        public DateTime TripDate { get; set; }

        public TripDetailsDTO(int tripPartId, int tripId, string origin, string destination, string busType, DateTime tripDate, TimeSpan departureTime, TimeSpan arrivalTime, int travelTime, decimal fareAmount, int availableSeats)
        {
            TripPartId = tripPartId;
            TripId = tripId;
            Origin = origin;
            Destination = destination;
            BusType = busType;
            TripDate = tripDate;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            TravelTime = travelTime;
            FareAmount = fareAmount;
            AvailableSeats = availableSeats;
        }
    }
}
