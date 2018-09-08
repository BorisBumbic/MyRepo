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
        public Rootobject GetUnprocessedInformationFromApi()
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
                    command.Parameters.Add(new SqlParameter("@CountryCode", item.code));
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
                    string sql = @"INSERT INTO VATInformation(Standard, Reduced, Reduced1, Reduced2, Super_reduced, parking, CountryCode, Taxdate)  
                                VALUES (@standard, @reduced, @reduced1, @reduced2, @superreduced, @parking, @CountryCode, @date)";

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
                        command.Parameters.Add(new SqlParameter("@CountryCode", item.code));
                        command.Parameters.Add(new SqlParameter("@date", item1.effective_from));
                        command.ExecuteNonQuery();
                    }
                }


            }
        }
        public void ConnectTables(Rootobject xs)
        {
            string sql = @"UPDATE VATInformation
                            SET VATInformation.CountryNameId = CountryNames.ID
                            FROM Vatinformation 
                            JOIN CountryNames ON CountryNames.CountryCode = VATInformation.CountryCode;";

            using (SqlConnection connection = new SqlConnection(directory))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<StandardVatList> ListStandardVAT()
        {
            string sql = @"SELECT Countrynames.country, vatinformation.standard
                     FROM Countrynames 
                     JOIN VatInformation ON VATInformation.CountryNameId = CountryNames.Id
                     ORDER BY VATInformation.standard desc";

            using (SqlConnection connection = new SqlConnection(directory))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<StandardVatList> descList = new List<StandardVatList>();

                while (reader.Read())
                {
                    var dL = new StandardVatList();

                    string countryName = reader.GetSqlString(0).Value;
                    double standardVat = reader.GetDouble(1);

                    dL.countryName = countryName;
                    dL.standardVat = standardVat;

                    descList.Add(dL);
                }
                return descList;
            }


        }
    }
}
//        public static StandardVatList()
//        {
//            string sql = @"select standard
//                From VatInformation
//Join Vatinformation on 

//        }
//    }
//}
