using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities;
using MySql.Data.MySqlClient;
using DatabaseRelated.Connection;
using DatabaseRelated.Mappers;


namespace DatabaseRelated.Repositories
{
    public class TripRepository: ITripRepository
    {
        public List<Trip> GetTripPartsByDateAndOriginDestination(DateTime date, string origin, string destination)
        {

            var trips = new List<Trip>();

            try
            {
                using (var conn = DatabaseConnection.Instance.GetConnection())
                {
                    conn.Open();
                    string query = @"
                                         SELECT  tp.trip_part_id as TripPartId, 
		                                         tp.trip_id as TripId, 
                                                 bt.name BusType, 
                                                 r.route_id as RouteId, 
                                                 t1.name Origin,
		                                         t2.name as Destination,
                                                 tp.sched_departure as DepartureTime,
                                                 f.amount as FareAmount,
                                                 t.trip_date as TripDate,
                                                 tp.sched_arrival as ArrivalTime,
                                                 tps.travel_time as TravelTime,
                                                 b.plate_no as PlateNo,
                                                 (
                                                    SELECT COUNT(*) 
                                                    FROM trip_seats tss 	
                                                    WHERE tss.trip_part_id = tp.trip_part_id AND tss.status = 'AVAILABLE'
                                                 )  AS AvailableSeats
                                          FROM trip_parts tp
                                          INNER JOIN trips t ON tp.trip_id = t.trip_id
                                          INNER JOIN routes r ON t.route_id = r.route_id
                                          INNER JOIN buses b ON  t.bus_id = b.bus_id
                                          INNER JOIN bus_types bt ON b.bus_type_id = bt.bus_type_id
                                          INNER JOIN terminals t1 ON t1.terminal_id = tp.from_terminal_id
                                          INNER JOIN terminals t2 ON t2.terminal_id = tp.to_terminal_id
                                          INNER JOIN route_stops rs1 ON rs1.route_id = r.route_id AND rs1.terminal_id = tp.from_terminal_id
                                          INNER JOIN route_stops rs2 ON rs2.route_id = r.route_id AND rs2.terminal_id = tp.to_terminal_id
                                          INNER JOIN terminal_pairs tps ON tps.from_terminal_id = rs1.terminal_id AND tps.to_terminal_id   = rs2.terminal_id
                                          LEFT JOIN fares f ON f.route_id = r.route_id AND f.from_sequence = rs1.stop_sequence AND f.to_sequence = rs2.stop_sequence
                                          INNER JOIN classes c ON f.class_id = c.class_id AND bt.class_id = f.class_id 
                                          WHERE DATE(t.trip_date) = @date
                                          AND LOWER(TRIM(t1.name)) = LOWER(TRIM(@origin))
                                          AND LOWER(TRIM(t2.name)) = LOWER(TRIM(@destination))";


                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@date", MySqlDbType.Date).Value = date.Date;
                        cmd.Parameters.Add("@origin", MySqlDbType.VarChar).Value = origin;
                        cmd.Parameters.Add("@destination", MySqlDbType.VarChar).Value = destination;

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trips.Add(EntityMapping.GetTrips(reader));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<Trip>(); 
            }
            return trips;
        }
    }
}
