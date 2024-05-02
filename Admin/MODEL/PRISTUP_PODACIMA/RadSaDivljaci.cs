using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaDivljaci
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;
        
        public static List<Divljac> getAnimals()
        {
            List<Divljac> divljac = new List<Divljac>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `DIVLJAC`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    divljac.Add(new Divljac()
                    {
                        DivljacId = reader.GetInt32(0),
                        Vrsta = reader.GetString(1)       
                    });
                }

                conn.Close();
                reader.Close();
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return divljac;
        }

    }
}
