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
    internal class RadSaOruzanimListom
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static void insertArmedSheet(String serijskiBroj, DateTime datumIzdavanja, String rokVazenja, String fabrickiBroj , String osoba)
        {
           

            string[] tmp = osoba.Split(' ');
            string jmb = tmp[0];

            int id = RadSaOsobama.getPersonId(jmb);

            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("dodaj_oruzani_list", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                  
                    cmd.Parameters.AddWithValue("@pSerijskiBroj", serijskiBroj);
                    cmd.Parameters.AddWithValue("@pDatumIzdavanja", datumIzdavanja.Date);
                    cmd.Parameters.AddWithValue("@pRokVazenja", rokVazenja);
                    cmd.Parameters.AddWithValue("@pFabrickiBroj", fabrickiBroj);
                    cmd.Parameters.AddWithValue("@pOsobaId", id);

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

        public static List<OruzaniList> getDataForGridView(String filter)
        {
            List<OruzaniList> podaci = new List<OruzaniList>();
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT o.JMB, o.Prezime, o.Ime, w.FabrickiBroj, m.MarkaOruzjaNaziv, vo.VrstaOruzjaNaziv,   k.Kalibar from " +
                                  "((((((bp_lovacki_savez.oruzani_list ol inner join bp_lovacki_savez.clan c on ol.OsobaId=c.OsobaId)" +
                                  "inner join bp_lovacki_savez.osoba o on c.OsobaId=o.OsobaId)inner join bp_lovacki_savez.oruzje w " +
                                  "on ol.FabrickiBroj=w.FabrickiBroj)inner join bp_lovacki_savez.vrsta_oruzja vo " +
                                  "on w.VrstaOruzjaId=vo.VrstaOruzjaId)inner join bp_lovacki_savez.marka_oruzja m " +
                                  "on w.MarkaOruzjaId=m.MarkaOruzjaId)inner join bp_lovacki_savez.kalibar_oruzja k " +
                                  "on w.KalibarOruzjaId=k.KalibarOruzjaId) where o.Prezime like @str or k.Kalibar like @str or m.MarkaOruzjaNaziv like @str or vo.VrstaOruzjaNaziv like @str";
                cmd.Parameters.AddWithValue("@str", filter + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    podaci.Add(new OruzaniList()
                    {
                        OsobaId = new Clan()
                        {
                            OsobaId = new Osoba()
                            {
                                JMB = reader.GetString(0),
                                Prezime = reader.GetString(1),
                                Ime = reader.GetString(2)
                            }
                        },
                        FabrickiBroj = new Oruzje()
                        {
                            FabrickiBroj = reader.GetString(3),
                            MarkaOruzjaId = new MarkaOruzja()
                            {
                                MarkaOruzjaNaziv = reader.GetString(4),
                            },
                            VrstaOruzjaId = new VrstaOruzja()
                            {
                                VrstaOruzjaNaziv = reader.GetString(5)
                            },
                            KalibarOruzjaId = new KalibarOruzja()
                            {
                                Kalibar = reader.GetString(6)
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
            finally { conn.Close(); }

            return podaci;
        }

        public static Boolean checkIfArmedSheetExists(String serijskiBroj)
        {
            Boolean result = false;
            List<OruzaniList> ol = new List<OruzaniList>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `ORUZANI_LIST`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ol.Add(new OruzaniList()
                    {
                        SerijskiBroj = reader.GetString(0)
                    }
                        );
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

            foreach (OruzaniList o in ol)
            {
                if (serijskiBroj.Equals(o.SerijskiBroj))
                    result = true;
            }

            return result;
        }

    }
}
