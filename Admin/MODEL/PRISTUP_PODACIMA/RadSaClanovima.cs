using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaClanovima
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static List<Clan> GetMembers()
        {
            List<Clan> clanovi = new List<Clan>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM clan c inner join osoba o on c.OsobaId=o.OsobaId";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    clanovi.Add(new Clan()
                    {
                        OsobaId = new Osoba()
                        {
                            OsobaId = reader.GetInt32(0),
                            JMB = reader.GetString(2),
                            Prezime = reader.GetString(4),
                            Ime = reader.GetString(5)
                            
                        },
                        Status = reader.GetString(1)
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
            return clanovi;
        }
      
        public static List<Clan> GetDataForFillGridView(string filter)
        {
            List<Clan> podaci = new List<Clan>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
               
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT o.JMB, o.BrojLicneKarte, o.Prezime, o.Ime, o.Adresa, o.Telefon, Status FROM bp_lovacki_savez.clan c " +
                                  "inner join osoba o on c.OsobaId=o.OsobaId " +
                                  "where o.JMB like @str or o.BrojLicneKarte like @str or o.Prezime like @str";

                cmd.Parameters.AddWithValue("@str", filter + "%");

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    podaci.Add(new Clan()
                    {
                        OsobaId = new Osoba()
                        {
                            JMB = reader.GetString(0),
                            BrojLicneKarte = reader.GetString(1),
                            Prezime = reader.GetString(2),
                            Ime = reader.GetString(3),
                            Adresa = reader.GetString(4),
                            Telefon = reader.GetString(5)

                        },
                        Status = reader.GetString(6)
                    });
                    
                }
                reader.Close();
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
            return podaci;
        }

        

        public static void insertIntoMembers(String JMB, String BrojLicneKarte, String Prezime, String Ime, String Adresa, String Telefon, String Status)
        {
            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("dodaj_clana", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pJMB", JMB);
                    cmd.Parameters.AddWithValue("@pBrojLK", BrojLicneKarte);
                    cmd.Parameters.AddWithValue("@pPrezime", Prezime);
                    cmd.Parameters.AddWithValue("@pIme", Ime);
                    cmd.Parameters.AddWithValue("@pAdresa", Adresa);
                    cmd.Parameters.AddWithValue("@pTelefon", Telefon);
                    cmd.Parameters.AddWithValue("@pStatus", Status);

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

        public static void updateMembers(String jmb, String brojLicneKarte, String prezime, String ime, String adresa, String telefon, String Status) 
        {  
            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("azuriraj_osobu_i_clana", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pBrojLK", brojLicneKarte);
                    cmd.Parameters.AddWithValue("@pPrezime", prezime);
                    cmd.Parameters.AddWithValue("@pIme", ime);
                    cmd.Parameters.AddWithValue("@pAdresa", adresa);
                    cmd.Parameters.AddWithValue("@pTelefon", telefon);
                    cmd.Parameters.AddWithValue("@pStatus", Status);
                    cmd.Parameters.AddWithValue("@pJmb", jmb);

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


        public static void deleteMember(int idClana)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from `CLAN` where OsobaId=@idClana";
                cmd.Parameters.AddWithValue("@idClana", idClana);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(MySqlException ex)
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
