using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Data
{
    internal class ConnectionDal
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=Haier-PC;Initial Catalog=Database1;Integrated Security=true;");
        }
    }
}
