using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dejabrew_pos.Functions
{
    class Login
    {
        Components.Connection con = new Components.Connection();
        Components.Value val = new Components.Value();

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = @"SELECT u.id, u.fullname, u.age, u.email, u.username
                                    FROM user AS u
                                    WHERE u.username = @username AND u.password = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.UserId = dt.Rows[0].Field<int>("id");
                            val.UserFullName = dt.Rows[0].Field<string>("fullname");
                            val.UserEmail = dt.Rows[0].Field<string>("email");
                            val.UserUsername = dt.Rows[0].Field<string>("username");

                            connection.Close();
                            return true;
                        }
                        else
                        {
                            connection.Close();
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error authenticating user: " + ex.ToString());
                return false;
            }
        }
    }
}
