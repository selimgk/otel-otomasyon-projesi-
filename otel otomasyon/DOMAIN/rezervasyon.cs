using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using otel_otomasyon.DAL;
using otel_otomasyon.SERVİCE;


namespace otel_otomasyon.DOMAIN
{
    public class rezervasyon
    {
        public rezervasyon(string fİsim, string fSoyisim, string fTckimlikno, string fGirişTarihi, string fÇıkışTarihi)
        {

            this.İsim = fİsim;
            this.Soyisim = fSoyisim;
            this.Tckimlikno = fTckimlikno;
            this.GirişTarihi = fGirişTarihi;
            this.ÇıkışTarihi = fÇıkışTarihi;
            



        }

    int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string isim;

        public string İsim
        {
            get { return isim; }
            set { isim = value; }
        }
        string soyisim;

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
        string tckimlikno;

        public string Tckimlikno
        {
            get { return tckimlikno; }
            set { tckimlikno = value; }
        }
        string giriştarihi;
        public string GirişTarihi
        {
            get { return giriştarihi; }
            set { giriştarihi = value; }
        }
        string çıkıştarihi;
        public string ÇıkışTarihi
        {
            get { return çıkıştarihi; }
            set { çıkıştarihi = value; }
        }
        
        public override string ToString()
        {
            return this.İsim + "" + this.Soyisim + "" + this.Tckimlikno + "" + this.GirişTarihi+ "" + this.ÇıkışTarihi;

        }

    }

}
