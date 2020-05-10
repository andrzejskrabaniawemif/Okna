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
        string connectionString = @"Data Source=DESKTOP-SS39255\SQLSERVER;Initial Catalog = WEMIF; Integrated Security = True"; 

        public int RunSQL(string query)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                SqlCommand command = new SqlCommand(query, cn);

                int value = command.ExecuteNonQuery();

                cn.Close();

                return value;
            }

        }

        public string GetField(string field, string table, string where)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = string.Format("SELECT {0} FROM {1} WHERE {2}", field, table, where);
                string value = "";

                cn.Open();

                SqlCommand command = new SqlCommand(query, cn);

                SqlDataReader dataReader = command.ExecuteReader();

                if(dataReader.Read())
                {
                    value = dataReader.GetValue(0).ToString();
                }

                cn.Close();

                return value;

            }

        }
        public Dictionary<string,string> GetValuesToChart(int userREF)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                string query = "SELECT measureDate, userWeight FROM History where userREF = " + userREF + " order by userREF asc";

                cn.Open();

                SqlCommand command = new SqlCommand(query, cn); 

                SqlDataReader dataReader = command.ExecuteReader();

                while(dataReader.Read())
                {
                    try
                    {
                        dictionary.Add(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString());
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
