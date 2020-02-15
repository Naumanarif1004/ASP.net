using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Ado.Net
{
    class DalConnection
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=HAIER-PC\\SQLEXPRESS,Initial Catalog=AcademicDB,Integrated Security=true");
        }
    }
}
