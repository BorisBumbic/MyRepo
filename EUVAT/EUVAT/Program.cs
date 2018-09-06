using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EUVAT
{
    class Program 
    {
        public void PopulateCountries()
        {
            foreach (var item in collection)
            {
                string nameString = item.;

                string directory = @"Server:(localdb)\mssqllocaldb; Database = Eurotaxes";

                string sql = @"INSERT INTO Countrynames(Country)
                            VALUES (@name)";

                using (SqlConnection connection = new SqlConnection(directory))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@name", nameString);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PupulateVAT()
        {
            foreach (var item in collection)
            {
                string standard = item.;
                string reduced = item.;
                string reducedOne = item.;
                string reducedTwo = item.;
                string parking = item.;
                string superReduced = item.;
                string fromDate = item.;

                string directory = @"Server:(localdb)\mssqllocaldb; Database = Eurotaxes";

                string sql = @"INSERT INTO VATInformation(Standard, Reduced, Reduced1, Reduced2, Super_reduced, parking, taxdate)
                            VALUES (@standard, @reduced, @reduced1, @reduced2, @superreduced, @parking, @date)";

                using (SqlConnection connection = new SqlConnection(directory))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@standard", standard);
                    command.Parameters.Add("@Reduced", reduced);
                    command.Parameters.Add("@Reduced1", reducedOne);
                    command.Parameters.Add("@Reduced2", reducedTwo);
                    command.Parameters.Add("@parking", parking);
                    command.Parameters.Add("@superreduced", superReduced);
                    command.Parameters.Add("@date", fromDate);
                    command.ExecuteNonQuery();
                }


            }
        }
    }
}
