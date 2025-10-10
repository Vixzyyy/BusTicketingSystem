using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Trip
    {
            public int Trip_part_id { get; set; }
            public int TripId { get; set; }
            public string BusType { get; set; }
            public int RouteId { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public TimeSpan DepartureTime { get; set; }
            public decimal Price { get; set; }
            public DateTime DepartureDate { get; set; }
            public TimeSpan ArrivalTime { get; set; }
            public int TravelTime { get; set; }
            public string PlateNo { get; set; }
            public int AvailableSeats { get; set; }

        public Trip(int trip_part_id, int trip_id, 
                     string bus_id, int route_id, 
                     string origin, string destination, 
                     TimeSpan departuretime, decimal price, 
                     DateTime departuredate, TimeSpan arrivaltime,
                     int traveltime, string plateNo, int availableSeats)
        {
            Trip_part_id = trip_part_id;
            TripId = trip_id;
            BusType = bus_id;
            RouteId = route_id;
            Origin = origin;
            Destination = destination;
            DepartureTime = departuretime;
            Price = price;
            DepartureDate = departuredate;
            ArrivalTime = arrivaltime;
            TravelTime = traveltime;
            PlateNo = plateNo; 
            AvailableSeats = availableSeats;
        }
    }
}
