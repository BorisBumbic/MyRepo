using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Gnomecheckpoint
{
    class DataAccess
    {
        string conString = @"Server=(localdb)\mssqllocaldb;Database=GnomeDb";

        public List<Gnome> GetGnomesFromDatabase()
        {
            string sql = @"select * from gnomes";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Gnome> GnomeList = new List<Gnome>();

                while(reader.Read())
                {
                    Gnome gnomey = new Gnome();

                    gnomey.id = reader.GetSqlInt32(0).Value;
                    gnomey.name = reader.GetSqlString(1).Value;
                    gnomey.beard = reader.GetSqlString(2).Value;
                    gnomey.alignment = reader.GetSqlString(3).Value;
                    gnomey.temperament = reader.GetSqlInt32(4).Value;
                    gnomey.race = reader.GetSqlString(5).Value;

                    GnomeList.Add(gnomey);
                }
                return GnomeList;
            }
        }
        public void AddGnome(string name)
        {
            Regex reggy = new Regex(@"(--|insert|select|update|\*|;)", RegexOptions.IgnoreCase);
            Match match = reggy.Match(name);
            if (match.Success)
            {
                Console.WriteLine("Invalid input! Try again!");
            }
            else
            {
                string sql = $"Insert into gnomes(name) values ('{name}')";

                using (SqlConnection connection = new SqlConnection(conString))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
            }

        }
    }

}


