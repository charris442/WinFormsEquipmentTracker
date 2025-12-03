using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WinFormsEquipmentTracker.Model;

namespace WinFormsEquipmentTracker.Data
{
    public class EquipmentRepository
    {
        private readonly string _connectionString;
        public EquipmentRepository()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["EquipmentDB"].ConnectionString;
        }

        public List<Equipment> GetAllEquipment()
        {
            var list = new List<Equipment>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT id, name, location, lastService, status, notes FROM equipment ORDER BY name";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var eq = new Equipment
                        {
                            Id = reader["id"].ToString(),
                            Name = reader["name"].ToString(),
                            Location = reader["location"] as string,
                            Status = reader["status"] as string,
                            Notes = reader["notes"] as string
                        };

                        if (reader["lastService"] != DBNull.Value)
                        {
                            eq.LastService = (DateTime)reader["lastService"];
                        }
                        else
                        {
                            eq.LastService = null;
                        }

                        list.Add(eq);
                    }
                }
            }

            return list;
        }

        public Equipment GetEquipmentById(string id)
        {
            Equipment eq = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT id, name, location, lastService, status, notes FROM equipment WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            eq = new Equipment
                            {
                                Id = reader["id"].ToString(),
                                Name = reader["name"].ToString(),
                                Location = reader["location"] as string,
                                Status = reader["status"] as string,
                                Notes = reader["notes"] as string
                            };

                            if (reader["lastService"] != DBNull.Value)
                                eq.LastService = (DateTime)reader["lastService"];
                            else
                                eq.LastService = null;
                        }
                    }
                }
            }

            return eq;
        }

        public void AddEquipment(Equipment equipment)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO equipment
                               (id, name, location, lastService, status, notes)
                               VALUES (@id, @name, @location, @lastService, @status, @notes)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", equipment.Id);
                    cmd.Parameters.AddWithValue("@name", equipment.Name);
                    cmd.Parameters.AddWithValue("@location",
                        (object)equipment.Location ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@status",
                        (object)equipment.Status ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@notes",
                        (object)equipment.Notes ?? DBNull.Value);

                    if (equipment.LastService.HasValue)
                        cmd.Parameters.AddWithValue("@lastService", equipment.LastService.Value.Date);
                    else
                        cmd.Parameters.AddWithValue("@lastService", DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
