using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace qlCar.DataAcess
{
    public class connectClass
    {
        public static string connectString = @"";
        public static SqlConnection getconnect()
        {
            return new SqlConnection(connectString);
        }

    }
}
