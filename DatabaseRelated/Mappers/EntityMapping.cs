using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using MySql.Data.MySqlClient;

namespace DatabaseRelated.Mappers
{
    public static class EntityMapping
    {
        public static Trip GetTrips(MySqlDataReader reader)
        {
            return new Trip(
                trip_part_id: reader.GetInt32("TripPartId"),
                trip_id: reader.GetInt32("TripId"),
                bus_id: reader.GetString("BusType"),
                route_id: reader.GetInt32("RouteId"),
                origin: reader.GetString("Origin"),
                destination: reader.GetString("Destination"),
                departuretime: reader.IsDBNull(reader.GetOrdinal("DepartureTime"))? TimeSpan.Zero: reader.GetTimeSpan("DepartureTime"),
                price: reader.GetDecimal("FareAmount"),
                departuredate: reader.GetDateTime("TripDate"),
                arrivaltime: reader.IsDBNull(reader.GetOrdinal("ArrivalTime"))? TimeSpan.Zero : reader.GetTimeSpan("ArrivalTime"),
                traveltime: reader.GetInt32("TravelTime"),
                plateNo: reader.GetString("PlateNo"),
                availableSeats: reader.GetInt32("AvailableSeats")
            );
        }

        public static Terminal GetTerminal(MySqlDataReader reader)
        {
            return new Terminal(
                reader.GetInt32("terminal_id"),
                reader.GetString("name"),
                reader.IsDBNull(reader.GetOrdinal("address")) ? "" : reader.GetString("address"),
                reader.IsDBNull(reader.GetOrdinal("city")) ? "" : reader.GetString("city"),
                reader.IsDBNull(reader.GetOrdinal("province")) ? "" : reader.GetString("province")
            );
        }
    }
}
