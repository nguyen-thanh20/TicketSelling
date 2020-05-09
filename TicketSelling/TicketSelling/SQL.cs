using System.Data;
using System.Data.SqlClient;

namespace TicketSelling
{
    public class SQL
    {
        private SqlConnection sql;
        public SQL(string Source, string user, string password, string database)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Source;
            builder.UserID = user;
            builder.Password = password;
            builder.InitialCatalog = database;

            sql = new SqlConnection(builder.ConnectionString);
        }
        public string checkQuote(string str)
        {
            if (str.Contains("'"))
            {
                str = str.Insert(str.IndexOf("'"), "'");
            }
            return str;
        }
        public string Read(int index, string query)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string value = (string)dataReader.GetValue(index);
                sql.Close();
                return value;
            }
            sql.Close();
            return null;
        }

        public DataSet Read(string query)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            data.Fill(ds);
            sql.Close();
            return ds;
        }
        public bool Add(string query)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.ExecuteNonQuery();
            sql.Close();
            return true;
        }
    }
}
