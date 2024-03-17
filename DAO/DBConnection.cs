using System.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO {
    public class DBConnection {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable ExecuteQueryDataTable(string query) {
            DataTable dt = new DataTable();
            if(conn.State == ConnectionState.Open) {
                conn.Close();
            }
            try {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                adapter.Fill(dt);

            } catch(Exception exc) {
                MessageBox.Show(exc.Message);
            } finally {
                conn.Close();
            }
            return dt;
        }

        public bool ExecuteNonQuery(string query, string msg = "Thực thi thất bại !") {
            try {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                if(cmd.ExecuteNonQuery() > 0) {
                    return true;
                }

            } catch(Exception ex) {
                MessageBox.Show($"{msg}\n{ex.Message}");

            } finally {
                conn.Close();
            }

            return false;
        }
    }
}
