using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public Samolot(int iloscMiejsc, int odleglosc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.odleglosc = odleglosc;
            ObliczCene();
        }
        public override void ObliczCene()
        {
            if (odleglosc > 200)
            {
                cenaBiletu = odleglosc * 2.56 * iloscMiejsc;
            }
            else
                cenaBiletu = 24 * iloscMiejsc;
        }

        public override string ToString()
        {
            return "Samolot: ilosc miejsc: " + iloscMiejsc + ",  odległość: " + odleglosc + ", cena biletu: " + cenaBiletu;
        }

    }
}
