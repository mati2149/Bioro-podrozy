using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Podroz : IData , IZarzadzaj
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> PlanPodrozy = new List<SrodekLokomocji>();
        private double koszt = 200;


        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now) return true;
            else return false;
        }

        public void DodajAutobus(int iloscMiejsc)
        {
            PlanPodrozy.Add(new Autobus(iloscMiejsc));
            int pomoc = PlanPodrozy.Count;
            koszt += PlanPodrozy[pomoc - 1].PobierzCene();
        }

        public void DodajSamolot(int iloscMiejsc, int odleglosc)
        {
            PlanPodrozy.Add(new Samolot(iloscMiejsc, odleglosc));
            int pomoc = PlanPodrozy.Count;
            koszt += PlanPodrozy[pomoc - 1].PobierzCene();
        }

        public void UsunOstatni()
        {
            if (PlanPodrozy.Count > 0) PlanPodrozy.Remove(PlanPodrozy.Last());
            int pomoc = PlanPodrozy.Count;
            try
            {
                koszt -= PlanPodrozy[pomoc - 1].PobierzCene();
            }
            catch
            {
                koszt = 200;
            }

        }

        public void Wyczysc()
        {
            koszt = 200;
            PlanPodrozy.Clear();
        }

        public override string ToString()
        {
            string info = "Plan podrozy: ";

            foreach (var element in PlanPodrozy)
            {
                info += Environment.NewLine + element.ToString();
            }
            info += Environment.NewLine + "Koszt: " + koszt;

            return info;
        }
    }
}
