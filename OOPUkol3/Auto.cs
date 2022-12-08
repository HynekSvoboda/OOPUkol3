using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUkol3
{
    internal class Auto
    {
        string znacka;
        double spotreba;
        int ujetoCelkem;
        DateTime okamzikRozjezdu;
        int dobaJizdyCelkem;
        bool jede;
        public bool Jede
        {
            get
            {
                return jede;
            }
        }
        public Auto(string znacka, double spotrebanasto)
        {
            this.znacka = znacka;
            this.spotreba = spotrebanasto;
            dobaJizdyCelkem = 0;
            ujetoCelkem = 0;
            jede = false;
        }

        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }
        public void Rozjed()
        {
            jede= true;
            okamzikRozjezdu= DateTime.Now;
        }
        public void Zastav(int pocetkilometru)
        {
            jede= false;
            TimeSpan rozdil = DateTime.Now - okamzikRozjezdu;
            dobaJizdyCelkem +=Convert.ToInt32(rozdil.TotalSeconds);
            ujetoCelkem += pocetkilometru;
        }
        public double CelkovaSpotreba()
        {
            double vypocet = (double)ujetoCelkem/ (double)spotreba;
            return Math.Round(vypocet, 3);
        }
        public override string ToString()
        {
           if(jede) return "Znacka auta: " + znacka + ", doba jizdy celkem: " + dobaJizdyCelkem.ToString() + " jednotek casu, celkova spotreba paliva: " + CelkovaSpotreba().ToString()+" (l), celkem ujeto: "+ujetoCelkem.ToString()+" Km"+", auto je v pohybu";
           else return "Znacka auta: " + znacka + ", doba jizdy celkem: " + dobaJizdyCelkem.ToString() + " jednotek casu, celkova spotreba paliva: " + CelkovaSpotreba().ToString() + " (l), celkem ujeto: " + ujetoCelkem.ToString() + " Km" + ", auto není v pohybu";
        }
    }
}
