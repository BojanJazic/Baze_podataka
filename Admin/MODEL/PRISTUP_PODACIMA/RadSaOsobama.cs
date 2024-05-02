using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaOsobama
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static int getPersonId(String jmb)
        {
            int result = -1;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `OSOBA` o where o.JMB=@jmb";
                cmd.Parameters.AddWithValue("@jmb", jmb);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    result = reader.GetInt32(6);
                }
                conn.Close();
                reader.Close();

                return result;

            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        public static int checkIfIdCardExist(String brojLK)
        {
            int result = -1;
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `OSOBA` o where o.BrojLicneKarte=@brojLK";
                cmd.Parameters.AddWithValue("@brojLK", brojLK);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result = reader.GetInt32(6);
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
            return result;
        }

        public static List<Osoba> GetPersons()
        {
            List<Osoba> persons = new List<Osoba>();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
               
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();    
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM `OSOBA`";
                MySqlDataReader reader = cmd.ExecuteReader();
                   while (reader.Read())
                   {
                      persons.Add(new Osoba()
                      { 
                          JMB = reader.GetString(0),
                          BrojLicneKarte = reader.GetString(1),
                          Prezime = reader.GetString(2),
                          Ime = reader.GetString(3),
                          Adresa = reader.GetString(4),
                          Telefon = reader.GetString(5),
                          OsobaId = reader.GetInt32(6)
                      });
                    }
                   reader.Close();       
                   conn.Close();        
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return persons;
        }

        public static void insertIntoPersons(String JMB, String BrojLicneKarte, String Prezime, String Ime, String Adresa, String Telefon)
        {
            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("dodaj_osobu", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pJMB", JMB);
                    cmd.Parameters.AddWithValue("@pBrojLK", BrojLicneKarte);
                    cmd.Parameters.AddWithValue("@pPrezime", Prezime);
                    cmd.Parameters.AddWithValue("@pIme", Ime);
                    cmd.Parameters.AddWithValue("@pAdresa", Adresa);
                    cmd.Parameters.AddWithValue("@pTelefon", Telefon);
                  
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
