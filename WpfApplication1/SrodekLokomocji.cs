using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        public virtual void ObliczCene()
        {
            cenaBiletu = Convert.ToInt32(iloscMiejsc * 3);
        }

        public SrodekLokomocji()
        { }

        public SrodekLokomocji(int iloscMiejsc)
        {
            this.iloscMiejsc = iloscMiejsc;
        }

        public double PobierzCene()
        {
            return this.cenaBiletu;
        }


    }
}
