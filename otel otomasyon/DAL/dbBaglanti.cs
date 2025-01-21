using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;

namespace otel_otomasyon.DAL
{
     class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330016; User=25_132330016; Password=!nif.ogr16GO;");
            baglanti.Open();
            return baglanti;
        }

    }
}
