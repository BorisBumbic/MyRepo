using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;



namespace Coutry
{
    class Commad
    {
        public Rootobject GetAllInformationFromApi()
        {
            using (var webClient1 = new HttpClient())
            {
                string content1 = webClient1.GetAsync("https://jsonvat.com/").Result.Content.ReadAsStringAsync().Result;

                var xs = JsonConvert.DeserializeObject<Rootobject>(content1);

                return xs;
            }
        }

        string directory = @"Server=(localdb)\mssqllocaldb; Database = Eurotaxes";

        public void PopulateCountries(Rootobject xs)
        {
            foreach (var item in xs.rates)
            {
                string sql = @"INSERT INTO Countrynames(Country, CountryCode)
                            VALUES (@name, @CountryCode)";

                using (SqlConnection connection = new SqlConnection(directory))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@name", item.name));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void PupulateVAT(Rootobject xs)
        {
            foreach (var item in xs.rates)
            {

                foreach (var item1 in item.periods)
                {
                    //läg till date
                    string sql = @"INSERT INTO VATInformation(Standard, Reduced, Reduced1, Reduced2, Super_reduced, parking)  
                                VALUES (@standard, @reduced, @reduced1, @reduced2, @superreduced, @parking)
                                UPDATE VATInformation ";

                    using (SqlConnection connection = new SqlConnection(directory))
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        command.Parameters.Add(new SqlParameter("@standard", item1.rates.standard));
                        command.Parameters.Add(new SqlParameter("@Reduced", item1.rates.reduced));
                        command.Parameters.Add(new SqlParameter("@Reduced1", item1.rates.reduced1));
                        command.Parameters.Add(new SqlParameter("@Reduced2", item1.rates.reduced2));
                        command.Parameters.Add(new SqlParameter("@parking", item1.rates.parking));
                        command.Parameters.Add(new SqlParameter("@superreduced", item1.rates.super_reduced));
                        //command.Parameters.Add(new SqlParameter("@date", item1.effective_from));
                        command.ExecuteNonQuery();
                    }
                }


            }
        }

        public void ConnectTables(Rootobject xs)
        {
            string sql = @"UPDATE VATInformation
                            SET CountryNameId = CountryNames.ID
                            WHERE CountryNames.Country = @name";

            foreach (var item in xs.rates)
            {



                using (SqlConnection connection = new SqlConnection(directory))
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add(new SqlParameter("@name", item.name));
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}

