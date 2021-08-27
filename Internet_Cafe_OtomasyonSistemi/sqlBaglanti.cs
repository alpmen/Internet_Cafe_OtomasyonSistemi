using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Internet_Cafe_OtomasyonSistemi
{
    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection
                ("Data Source=DESKTOP-38F6FLL\\MSSQLSERVER2014;Initial Catalog=Internet_Cafe_Otomasyon_Sistemi;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
