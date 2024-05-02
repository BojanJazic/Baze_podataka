using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Authentication;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaClanskomKartom
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static List<ClanskaKarta> getMemberShipCard()
        {
            List<ClanskaKarta> clanskaKarta = new List<ClanskaKarta>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select OsobaId from `CLANSKA_KARTA`";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clanskaKarta.Add(new ClanskaKarta()
                    {
                        OsobaId = new Clan() { 
                            OsobaId = new Osoba()
                            {
                                OsobaId = reader.GetInt32(0)
                            }
                        }
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
            return clanskaKarta;
        }

        public static void insertIntoMemberShipCard(DateTime datumUclanjivanja, String datumIsclanjivanja, int idClana)
        {
            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("clanska_karta", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pDatumUclanjivanja", datumUclanjivanja.Date);
                    cmd.Parameters.AddWithValue("@pDatumIsclanjivanja", datumIsclanjivanja);
                    cmd.Parameters.AddWithValue("@pOsobaId", idClana);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

    }
}
