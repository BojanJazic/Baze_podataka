using Admin.MODEL.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin.MODEL.PRISTUP_PODACIMA
{
    internal class RadSaOruzjem
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DB_Lovacki_Savez"].ConnectionString;

        public static List<Oruzje> getWeapons()
        {
            List<Oruzje> oruzje = new List<Oruzje>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select o.FabrickiBroj, v.VrstaOruzjaNaziv, m.MarkaOruzjaNaziv, k.Kalibar from " +
                    "(((bp_lovacko_udruzenje.oruzje o inner join bp_lovacko_udruzenje.vrsta_oruzja v " +
                    "on o.VrstaOruzjaId=v.VrstaOruzjaId) inner join bp_lovacko_udruzenje.marka_oruzja m" +
                    " on o.MarkaOruzjaId=m.MarkaOruzjaId) inner join bp_lovacko_udruzenje.kalibar_oruzja k " +
                    "on o.KalibarOruzjaId=k.KalibarOruzjaId);";

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    oruzje.Add(new Oruzje()
                    {
                        FabrickiBroj = reader.GetString(0),
                        VrstaOruzjaId = new VrstaOruzja()
                        {
                            VrstaOruzjaNaziv = reader.GetString(1)
                        },
                        MarkaOruzjaId = new MarkaOruzja()
                        {
                            MarkaOruzjaNaziv = reader.GetString(2)
                        },
                        KalibarOruzjaId = new KalibarOruzja()
                        {
                            Kalibar = reader.GetString(3)
                        }
                    });
                }

                conn.Close();
                reader.Close();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return oruzje;
        }

        public static List<string> getWeaponsType()
        {
            List<string> vrste = new List<string>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `VRSTA_ORUZJA`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    vrste.Add(
                            reader.GetString(1)
                        );
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


            return vrste;
        }

        public static List<string> getWeaponsBrand()
        {
            List<string> marka = new List<string>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `MARKA_ORUZJA`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marka.Add(
                            reader.GetString(1)
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


            return marka;
        }

        public static List<string> getWeaponsCaliber()
        {
            List<string> kalibar = new List<string>();

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `KALIBAR_ORUZJA`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kalibar.Add(
                            reader.GetString(1)
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


            return kalibar;
        }

        public static void insertWeapon(String fabrickiBroj, String vrstaOruzja, String markaOruzja, String kalibarOruzja)
        {
            int idVrste = getIdOfTWeaponType(vrstaOruzja);
            int idMarke = getIdOfTWeaponBrand(markaOruzja);
            int idKalibra = getIdOfTWeaponCaliber(kalibarOruzja);
            // Console.WriteLine("ID vrste: " + idVrste + ", ID marke: " + idMarke + ", ID kalibra: " + idKalibra);

            MySqlConnection conn = null;
            using (conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("dodaj_oruzje", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pFabrickiBroj", fabrickiBroj);
                    cmd.Parameters.AddWithValue("@pVrstaOruzjaId", idVrste);
                    cmd.Parameters.AddWithValue("@pMarkaOruzjaId", idMarke);
                    cmd.Parameters.AddWithValue("@pKalibarId", idKalibra);

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

        private static int getIdOfTWeaponType(String vrsta)
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select VrstaOruzjaId from `VRSTA_ORUZJA` where VrstaOruzjaNaziv=@vrsta";
                cmd.Parameters.AddWithValue("@vrsta", vrsta);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                conn.Close();
                reader.Close();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return id;
        }

        private static int getIdOfTWeaponBrand(String marka)
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select MarkaOruzjaId from `MARKA_ORUZJA` where MarkaOruzjaNaziv=@marka";
                cmd.Parameters.AddWithValue("@marka", marka);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
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

            return id;
        }

        private static int getIdOfTWeaponCaliber(String kalibar)
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select KalibarOruzjaId from `KALIBAR_ORUZJA` where Kalibar=@kalibar";
                cmd.Parameters.AddWithValue("@kalibar", kalibar);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
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

            return id;
        }

        public static Boolean checkIfExist(String fabrickiBroj)
        {
            Boolean result = false;
            List<Oruzje> oruzje = new List<Oruzje>();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from `ORUZJE`";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    oruzje.Add(new Oruzje()
                        {
                            FabrickiBroj = reader.GetString(0)
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

            foreach(Oruzje o in oruzje)
            {
                if (fabrickiBroj.Equals(o.FabrickiBroj))
                    result = true;
            }

            return result;
        }
    }
}
