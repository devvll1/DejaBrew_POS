using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace dejabrew_pos.Components
{
    internal class Connection
    {
        Components.Value val = new Components.Value();

        public string conString()
        {
            return String.Format("datasource = {0}; username = {1}; password = {2}; port = {3}; database = {4};",
                                    val.serverName, val.serverUser, val.serverPass, val.port, val.database);
        }
    }
}
