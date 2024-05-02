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
    internal class RadSaLovnimKalendarom
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;
       
        public static List<LovniKalendar> getCalender()
        {
            List<LovniKalendar> lovniKalendar = new List<LovniKalendar>();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `LOVNI_KALENDAR`";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lovniKalendar.Add(new LovniKalendar()
                    {
                        KalendarLovaId = reader.GetInt32(0),
                        DatumPocetka = reader.GetDateTime(1).Date,
                        DatumZavrsetka = reader.GetDateTime(2).Date
                    });
                }

                conn.Close();
                reader.Close();

            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
                conn.Close(); 
            }

            return lovniKalendar;
        }

        public static int getLastInsertedId()
        {
            int lastInsertedId = -1;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select KalendarLovaId from bp_lovacko_udruzenje.lovni_kalendar " +
                                  "where KalendarLovaId = (select max(KalendarLovaId) from bp_lovacko_udruzenje.lovni_kalendar);";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lastInsertedId = reader.GetInt32(0);
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
            return lastInsertedId;
        }

        public static void insertIntoCalender(DateTime datumPocetka, DateTime datumZavrsetka)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
          
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into `LOVNI_KALENDAR` (DatumPocetka, DatumZavrsetka) values (@datumPocetka, @datumZavrsetka);";
                cmd.Parameters.AddWithValue("@datumPocetka", datumPocetka);
                cmd.Parameters.AddWithValue("@datumZavrsetka", datumZavrsetka);
                
                cmd.ExecuteNonQuery();
                
                conn.Close();
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
                conn.Close(); 
            }
        
        }

        public static void insertIntoCalenderOfAnimals(int divljacId, int kalendarLovaId, int brojnost)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into `LOVNI_KALENDAR_DIVLJACI` (DivljacId, KalendarLovaId, Brojnost) values(@divljacId, @kalendarLovaId, @brojnost)";
                cmd.Parameters.AddWithValue("@divljacId", divljacId);
                cmd.Parameters.AddWithValue("@kalendarLovaId", kalendarLovaId);
                cmd.Parameters.AddWithValue("@brojnost", brojnost);
                cmd.ExecuteNonQuery();

            }catch(MySqlException ex)
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
