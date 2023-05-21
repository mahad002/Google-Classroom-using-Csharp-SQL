using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10___21i_1239
{
    internal class Class1
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cs = new SqlCommand();
        SqlDataReader dr;
        private string con;
        public string MyConnection()
        {
            con = @"Data Source=DESKTOP-MQI17Q1\SQLEXPRESS;Initial Catalog=DB;Integrated Security=True";
            return con;
        }
    }
}
