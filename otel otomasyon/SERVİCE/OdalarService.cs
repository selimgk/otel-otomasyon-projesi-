using otel_otomasyon.DAL;
using otel_otomasyon.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otel_otomasyon.SERVİCE
{
    public class OdalarService
    {
        public void odaKaydet(int fOdaFiyatı, string fOdaTipi, string fOdaNumarası, string fOdaDurumu)
        {
            (new OdalarDAO()).odaKaydet(new Odalar(fOdaFiyatı, fOdaTipi, fOdaNumarası, fOdaDurumu));
        }
    }
}
