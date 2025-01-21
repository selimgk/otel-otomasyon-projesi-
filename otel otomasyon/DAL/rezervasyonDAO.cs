using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otel_otomasyon.DOMAIN;
using MySql.Data.MySqlClient;
using otel_otomasyon.SERVİCE;
using System.Collections;
using System.Windows.Forms;
using System.Data;


namespace otel_otomasyon.DAL
{
   



    public class rezervasyonDAO
    {
        dbBaglanti bgl = new dbBaglanti();  
        public void rezervasyonKaydet(rezervasyon frezervasyon)
        {
             MySqlCommand ekle = new MySqlCommand("insert into tbl_rezervasyon (İsim,Soyisim,Tckimlikno,GirişTarihi,ÇıkışTarihi) values (@a1,@a2,@a3,@a4,@a5)", bgl.baglantiGetir());
            ekle.Parameters.AddWithValue("@a1", frezervasyon.İsim);
            ekle.Parameters.AddWithValue("@a2", frezervasyon.Soyisim);
            ekle.Parameters.AddWithValue("@a3", frezervasyon.Tckimlikno);          
            ekle.Parameters.AddWithValue("@a4", frezervasyon.GirişTarihi);
            ekle.Parameters.AddWithValue("@a5", frezervasyon.ÇıkışTarihi);
            ekle.ExecuteNonQuery();
            MessageBox.Show("başarıyla eklenmiştir");
        }

        






    }
}
