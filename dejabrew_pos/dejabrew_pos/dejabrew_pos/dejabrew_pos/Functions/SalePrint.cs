using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dejabrew_pos.Functions
{
    internal class SalePrint
    {
        Components.Connection con = new Components.Connection();
        public void printData(ReportViewer report)
        {

            try
            {
                using (MySqlConnection connection = new MySqlConnection(con.conString()))
                {
                    string sql = "SELECT * FROM orders";

                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        connection.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();

                        dt.Clear();
                        da.Fill(dt);

                        ReportDataSource source = new ReportDataSource("dsOrders", dt);
                        report.LocalReport.DataSources.Clear();
                        report.LocalReport.DataSources.Add(source);
                        report.RefreshReport();

                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading print preview of products: " + ex.ToString());
            }
        }

    }
}
