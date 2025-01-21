using MySql.Data.MySqlClient;
using otel_otomasyon.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otel_otomasyon.SERVİCE;
using System.Windows.Forms;

namespace otel_otomasyon.DAL
{
    public class OdalarDAO
    {
        dbBaglanti bgl = new dbBaglanti();
        public void odaKaydet(Odalar fodalar)
        {
            {
                MySqlCommand ekle = new MySqlCommand("insert into tbl_odalar (OdaFiyatı,OdaTipi,OdaNumarası,OdaDurumu) values (@a1,@a2,@a3,@a4)", bgl.baglantiGetir());
                ekle.Parameters.AddWithValue("@a1", fodalar.OdaFiyatı);
                ekle.Parameters.AddWithValue("@a2", fodalar.OdaTipi);
                ekle.Parameters.AddWithValue("@a3", fodalar.OdaNumarası);
                ekle.Parameters.AddWithValue("@a4", fodalar.OdaDurumu);
                ekle.ExecuteNonQuery();
                MessageBox.Show("başarıyla eklenmiştir");
            }
        }
    }
}
