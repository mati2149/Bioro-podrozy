using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    interface IZarzadzaj
    {
        void DodajAutobus(int iloscMiejsc);
        void DodajSamolot(int iloscMiejsc, int odleglosc);
        void UsunOstatni();
        void Wyczysc();

    }
}
