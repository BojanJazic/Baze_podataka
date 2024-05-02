using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaAdministratorom
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static List<Administrator> getAdmin()
        {
            List<Administrator> admin = new List<Administrator>();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `ADMINISTRATOR`";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    admin.Add(new Administrator()
                    {
                        KorisnickoIme = reader.GetString(0),
                        Lozinka = reader.GetString(1),
                        Id = new Osoba()
                        {
                            OsobaId = reader.GetInt32(2)
                        }
                    });
                }
                conn.Close();
                reader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return admin;
        }

        public static void insertIntoAdmin(String JMB, String brojLK, String prezime, String ime, String adresa, String brojTelfona, String username, String password)
        {
            RadSaOsobama.insertIntoPersons(JMB, brojLK, prezime, ime, adresa, brojTelfona);
            int id = RadSaOsobama.getPersonId(JMB);
            Console.WriteLine(id);
            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("dodaj_admina", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pId", id);
                    cmd.Parameters.AddWithValue("@pKorisnickoIme", username);
                    cmd.Parameters.AddWithValue("@pLozinka", password);

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

        public static void updateAdmin(String password, int id)
        {
            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {


                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("azuriraj_lozinku", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pId", id);
                    cmd.Parameters.AddWithValue("@pLozinka", password);

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

