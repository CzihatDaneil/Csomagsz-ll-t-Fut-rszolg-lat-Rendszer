using System;
using System.Collections.Generic;
using System.Text;

namespace Csomagszállító_Futárszolgálat_Rendszer
{
    public class Csomag
    {
        private int sulyKg;
        private int tavolsagKm;
        private static int osszesCsomagSzam = 0;

        public string CsomagKod { get; set; }
        public string Cimzett { get; set; }
        public int SulyKg
        {
            get { return sulyKg; }
            set
            {
                if (value < 0)
                {
                    sulyKg = 1;
                }
                sulyKg = value;
            }
        }
        public int TavolsagKm
        {
            get { return tavolsagKm; }
            set
            {
                if (value < 0)
                {
                    tavolsagKm = 1;
                }
                tavolsagKm = value;
            }
        }
        public int OsszesCsomagSzam
        {
            get { return OsszesCsomagSzam; }
        }

        public Csomag(string csomagKod, string cimzett, int sulyKg) :this(csomagKod, cimzett, sulyKg, 2)
        { 
        }
        public Csomag(string csomagKod, string cimzett, int sulyKg, int tavolsagKm) 
        {
            CsomagKod = csomagKod;
            Cimzett = cimzett;
            SulyKg = sulyKg;
            TavolsagKm = tavolsagKm;
            osszesCsomagSzam++;
        }
        public int KiszallitasiDij()
        {
            return 500 + (tavolsagKm * 100) + (sulyKg * 2000);
            
        }
        public override string ToString() 
        {
            return $"[{CsomagKod}] Címzett: {Cimzett} | Súly: {SulyKg} kg | Távolság: {TavolsagKm} km | Díj: {KiszallitasiDij()} Ft";
        }

    }
}
