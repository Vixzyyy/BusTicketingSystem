using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseRelated.Connection;
using DatabaseRelated.Repositories;
using Application.DTOs;


namespace Application.Services
{
    public class TripService
    {
        private readonly TripRepository _tripPartRepository;

        public TripService()
        {
            _tripPartRepository = new TripRepository();
        }

        public List<TripDetailsDTO> GetTrips(DateTime date, string origin, string destination)
        {
            var trips = _tripPartRepository.GetTripPartsByDateAndOriginDestination(date, origin, destination);
            var dtoList = new List<TripDetailsDTO>();

            foreach (var t in trips)
            {
                var dto = new TripDetailsDTO(
                    tripPartId: t.Trip_part_id,
                    tripId: t.TripId,
                    origin: t.Origin,
                    destination: t.Destination,
                    busType: t.BusType,
                    tripDate: t.DepartureDate,
                    departureTime: t.DepartureTime,
                    arrivalTime: t.ArrivalTime,
                    travelTime: t.TravelTime,
                    fareAmount: t.Price,
                    availableSeats: t.AvailableSeats
                );
                dtoList.Add(dto);
            }
            return dtoList;
        }

        public bool SqlTestConnection()
        {
            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
