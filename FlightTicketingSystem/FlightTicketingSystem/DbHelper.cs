using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FlightTicketingSystem
{
    public static class DbHelper
    {
        public static SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["FlightDB"].ConnectionString;
            return new SqlConnection(connString);
        }

    }
}
