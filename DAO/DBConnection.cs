using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO {
    public class DBConnection {
        private SqlConnection connection = new SqlConnection(Properties.Settings.Default.connStr);
        private SqlCommand command = null;
        SqlDataAdapter adapter = null;

        private void CloseConnection() {
            if(connection.State == ConnectionState.Open)
                connection.Close();
        }

        public DataTable ExecuteQueryDataTable(string query) {
            DataTable table;

            using(command = new SqlCommand(query, connection)) {
                connection.Open();

                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }


        public DataTable ExecuteQueryDataTable(string query, SqlParameter[] sqlParameters) {
            CloseConnection();
            DataTable table;
            using(command = new SqlCommand(query, connection)) {
                connection.Open();


                foreach(SqlParameter sqlParameter in sqlParameters) {
                    command.Parameters.Add(sqlParameter);
                }

                adapter = new SqlDataAdapter(command);
                table = new DataTable();
                table.Clear();
                adapter.Fill(table);
                connection.Close();
            }
            return table;
        }

        public bool ExecuteNonQuery(string query) {
            CloseConnection();
            bool isQuery = false;
            using(command = new SqlCommand(query, connection)) {
                connection.Open();


                try {
                    command.ExecuteNonQuery();
                    isQuery = true;
                } catch(SqlException sql) {
                    MessageBox.Show(sql.Message);
                }

                connection.Close();
            }

            return isQuery;
        }

        public bool ExecuteNonQuery(string query, SqlParameter[] sqlParameters) {
            bool isQuery = false;
            CloseConnection();
            using(command = new SqlCommand(query, connection)) {
                connection.Open();


                foreach(SqlParameter sqlParameter in sqlParameters) {
                    command.Parameters.Add(sqlParameter);
                }

                if(command.ExecuteNonQuery() != 0)
                    isQuery = true;


                connection.Close();
            }

            return isQuery;
        }

        public int MyExecuteScalar(string query, CommandType commandType) {
            int q = 0;
            CloseConnection();
            using(command = new SqlCommand(query, connection)) {
                connection.Open();

                command.CommandType = commandType;

                try {
                    q = Convert.ToInt32(command.ExecuteScalar());
                } catch(SqlException sql) {
                    MessageBox.Show(sql.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
            return q;
        }
    }
}
