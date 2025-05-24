using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeniden
{
    public class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=NAGINI\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            baglan.Open();
            return baglan;

        }

    }
}
