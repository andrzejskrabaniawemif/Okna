using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Globalization;

namespace Okna.Classes
{
    class SQLConnection
    {
        string connectionString = @"Data Source=DESKTOP-SS39255\SQLSERVER;Initial Catalog = WEMIF; Integrated Security = True"; //

        public int RunSQL(string query) //odpalanie zpaytania
        {
            using (SqlConnection cn = new SqlConnection(connectionString)) //zeby nie zasmiecac programu, obiekt istnieje na czas wykonywania tego co jest w usingu
            {
                cn.Open(); //otwarcie pol z baza

                SqlCommand command = new SqlCommand(query, cn); //formuje zapytanie


                int value = command.ExecuteNonQuery(); //odpalanie zapytania a commandzie

                cn.Close();

                return value; //ilosc wykonan
            }

        }

        public string GetField(string field, string table, string where) // pobiera wartosc pola z okreslnej tabli w okreslonej dziedzinie
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT {0} FROM {1} WHERE {2}", field, table, where); //formowanie zapytania
                string value = ""; //zmienna przeochwujaca zwrocona wartosc pola

                cn.Open();

                SqlCommand command = new SqlCommand(query, cn);

                SqlDataReader dataReader = command.ExecuteReader(); //tworzy obeikt klasy i przypisuje do niego odpalone zpaytanie

                if(dataReader.Read()) //jesli sa rekordy to wyciaga
                {
                    value = dataReader.GetValue(0).ToString(); //przypisuje do zmiennej wartosc pola
                }

                cn.Close();

                return value;

            }

        }
        public Dictionary<string,string> GetValuesToChart(int userREF)
        {
            List<string> values = new List<string>();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = "SELECT measureDate, userWeight FROM History where userREF = " + userREF + " order by measureDate asc"; //formowanie zapytania
                string value = ""; //zmienna przeochwujaca zwrocona wartosc pola

                cn.Open();

                SqlCommand command = new SqlCommand(query, cn);

                SqlDataReader dataReader = command.ExecuteReader(); //tworzy obeikt klasy i przypisuje do niego odpalone zpaytanie

                while(dataReader.Read())
                {
                    try
                    {
                        dictionary.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString()); //uzupelniamy slowniak o wartosc daty i wagi
                    }
                    catch
                    {
                        continue; //pomijamy jesli juz taki rekord istnieje w slowniku
                    }
                }

                cn.Close();

                return dictionary;

            }
        }
    }
}
