using System;
using System.Collections.Generic;
using DatabaseRelated.Connection;
using DatabaseRelated.Mappers;
using Domain.Entities;
using Domain.Interfaces;
using MySql.Data.MySqlClient;

namespace DatabaseRelated
{
    public class TerminalRepository : ITerminalRepository
    {
        public List<Terminal> GetAllTerminals()
        {
            var terminals = new List<Terminal>();

            using (var conn = DatabaseConnection.Instance.GetConnection())
            {
                conn.Open();

                string query = "SELECT terminal_id, name, address, city, province FROM terminals ORDER BY name ASC";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        terminals.Add(EntityMapping.GetTerminal(reader));
                    }
                }
            }

            return terminals;
        }
    }
}
