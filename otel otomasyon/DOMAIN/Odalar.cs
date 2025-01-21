using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otel_otomasyon.DAL;
using otel_otomasyon.SERVİCE;

namespace otel_otomasyon.DOMAIN
{
    public class Odalar
    {
        public Odalar(int fOdaFiyatı, string fOdaTipi, string fOdaNumarası, string fOdaDurumu)
        {
            this.OdaFiyatı = fOdaFiyatı;
            this.OdaTipi = fOdaTipi;
            this.OdaNumarası = fOdaNumarası;
            this.OdaDurumu = fOdaDurumu;
        }
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        int odafiyatı;

        public int OdaFiyatı
        {
            get { return odafiyatı; }
            set { odafiyatı = value; }

        }
        string odatipi;

        public string OdaTipi
        {
            get { return odatipi; }
            set { odatipi = value; }

        }
        string odanumarası;

        public string OdaNumarası
        {
            get { return odanumarası; }
            set { odanumarası = value; }
        }
        string odadurumu;

        public string OdaDurumu
        {
            get { return odadurumu; }
            set { odadurumu = value; }

        }
        public override string ToString()
        {
            return this.OdaFiyatı + "" + this.OdaTipi + "" + this.OdaNumarası + "" + this.OdaDurumu;

        }
    }
}
