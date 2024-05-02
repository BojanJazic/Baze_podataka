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
    internal class RadSaEvidencijomOdstrela
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static List<EvidencijaOdstrela> getData(string filter)
        {
            List<EvidencijaOdstrela> evidencija = new List<EvidencijaOdstrela>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT e.EvidencijaOdstrelaId, d.Vrsta, concat(o.Prezime, ' ', o.Ime) as \"Clan\"," +
                                  "e.DatumOdstrela FROM ((bp_lovacko_udruzenje.evidencija_odstrela e inner join " +
                                  "bp_lovacko_udruzenje.divljac d on e.DivljacId=d.DivljacId)inner join " +
                                  "bp_lovacko_udruzenje.osoba o on e.OsobaId=o.OsobaId) where d.Vrsta like @str or o.Prezime like @str or o.Ime like @str";
               cmd.Parameters.AddWithValue("@str", filter + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    evidencija.Add(new EvidencijaOdstrela()
                    {
                        EvidencijaOdstrelaId = reader.GetInt32(0),
                        DivljacId = new Divljac()
                        {
                            Vrsta = reader.GetString(1)
                        },
                        OsobaId = new Osoba()
                        {
                            Prezime = reader.GetString(2)
                        },
                        DatumOdstrela = reader.GetDateTime(3)
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


            return evidencija;
        }

        public static void insertRecord(int idDivljaci, int idOsobe, DateTime datumOdstrela)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into `EVIDENCIJA_ODSTRELA` (DivljacId, OsobaId, DatumOdstrela) " +
                                  "values (@idDivljaci, @idOsobe, @datumOdstrela)";
                cmd.Parameters.AddWithValue("@idDivljaci", idDivljaci);
                cmd.Parameters.AddWithValue("@idOsobe", idOsobe);
                cmd.Parameters.AddWithValue("@datumOdstrela", datumOdstrela.Date);
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
