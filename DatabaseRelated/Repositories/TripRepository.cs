using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using MySql.Data.MySqlClient;
using DatabaseRelated.Connection;

namespace DatabaseRelated.Repositories
{
    public class TripRepository: ITripRepository
    {
        private readonly DatabaseConnection DB;

        public TripRepository(DatabaseConnection db)
        {
            DB = db;
        }

        public List<Trip> GetTripsByDateAndRoute(DateTime date, int routeId)
        {
            var trips = new List<Trip>();

            using (var conn = DB.GetConnection())  
            {
                conn.Open();
                string query = @"
                                 SELECT Trip, BusId, RouteId, DepartureTime 
                                 FROM trips 
                                 WHERE RouteId = @routeId AND DATE(DepartureTime) = @date";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@routeId", routeId);
                    cmd.Parameters.AddWithValue("@date", date.Date);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trips.Add(new Trip
                            {
                                TripId = reader.GetInt32("TripId"),
                                BusId = reader.GetInt32("BusId"),
                                RouteId = reader.GetInt32("RouteId"),
                                DepartureTime = reader.GetDateTime("DepartureTime")
                            });
                        }
                    }
                }
            }
            return trips;
        }
    }
}
