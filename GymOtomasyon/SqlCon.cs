using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GymOtomasyon
{
    public class SqlCon
    {
        public SqlConnection con() 
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=CarbonFit;Integrated Security=True;Encrypt=False") ;
            con.Open();
            return con ;
        }
    }
}
