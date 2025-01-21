using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otel_otomasyon.DAL;
using otel_otomasyon.DOMAIN;
using System.Collections;
using MySql.Data.MySqlClient;


namespace otel_otomasyon.SERVİCE
{
    class rezervasyonService
    {
        public void rezervasyonKaydet(string fİsim, string fSoyisim, string fTckimlikno, string fGirişTarihi, string fÇıkışTarihi)
        {
            (new rezervasyonDAO()).rezervasyonKaydet(new rezervasyon(fİsim, fSoyisim, fTckimlikno,  fGirişTarihi, fÇıkışTarihi));
        }


    }
}

