using System.Data;
using System.Data.SqlClient;

namespace QuanLyThienNguyen.DAL
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionString = "Data Source=HAOVIPPRO\\HAO;Initial Catalog=PBL3;Integrated Security=True;";

        public static DataProvider Instance 
        { 
            get
            {
                if (instance == null)
                   instance = new DataProvider();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }
        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();
                
                connection.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
