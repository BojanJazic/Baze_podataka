using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaSekcijama
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static List<Sekcija> GetSections()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            List<Sekcija> sekcije = new List<Sekcija>();
            try
            {
                
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from `SEKCIJA`";
           
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sekcije.Add(new Sekcija()
                    {
                        SekcijaId = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        BrojClanova = reader.GetInt32(2)
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

            return sekcije;
        }

        public static List<Sekcija> GetSections(string filter)
        {
            List<Sekcija> sekcije = new List<Sekcija>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
               
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select * from `SEKCIJA` s where s.Naziv like @str";
                cmd.Parameters.AddWithValue("@str", filter + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sekcije.Add(new Sekcija()
                    {
                        SekcijaId = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        BrojClanova = reader.GetInt32(2)
                    });
                }
                reader.Close();
                conn.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { 
                conn.Close(); 
            }

            return sekcije;
        }

        public static void insertIntoSection(String naziv, int brojClanova)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into `SEKCIJA` (Naziv, BrojClanova) values (@naziv, @brojClanova)";
               
                cmd.Parameters.AddWithValue("@naziv", naziv);
                cmd.Parameters.AddWithValue("@brojClanova", brojClanova);

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

        public static void deleteSection(int SekcijaId)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
               
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = @"delete from `SEKCIJA` where SekcijaId=@SekcijaId";

                cmd.Parameters.AddWithValue("@SekcijaId", SekcijaId);

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

        public static void updateSection(int SekcijaId, string Naziv, int BrojClanova)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
               
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "update `SEKCIJA` set Naziv=@Naziv, BrojClanova=@BrojClanova where SekcijaId=@SekcijaId";

                cmd.Parameters.AddWithValue("@Naziv", Naziv);
                cmd.Parameters.AddWithValue("@BrojClanova", BrojClanova);
                cmd.Parameters.AddWithValue("@SekcijaId", SekcijaId);

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
