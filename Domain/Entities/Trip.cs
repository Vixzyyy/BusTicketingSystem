using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Trip
    {
            public int TripId { get; set; }
            public int BusId { get; set; }
            public int RouteId { get; set; }
            public DateTime DepartureTime { get; set; }
            public decimal Price { get; set; }
    }
}
