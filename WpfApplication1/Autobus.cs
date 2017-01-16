using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
            ObliczCene();
        }

        public override string ToString()
        {
            return "Autobus: ilosc miejsc: " + iloscMiejsc + ", cena biletu: " + cenaBiletu;
        }


    }
}
