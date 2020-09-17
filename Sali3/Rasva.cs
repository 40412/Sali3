using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sali3
{
    class Rasva
    {
        public string ika;
        public string sukupuoli;

        public Rasva()
        {
            this.ika = "0";
            this.sukupuoli = "Nainen";
        }

        public Rasva(String sukupuoli, string ika)
        {
            this.sukupuoli = sukupuoli;
            this.ika = ika;
        }

        public float Rasvaprosentti(float pituus, float paino)
        {
            float bmi = paino / (pituus * pituus);
            float sukupuolikerroin;
            if(this.sukupuoli == "Nainen")
            {
                sukupuolikerroin = 0;
            } else
            {
                sukupuolikerroin = 1;
            }
            return 1.2f * bmi + 0.23f * float.Parse(this.ika) - 10.8f * sukupuolikerroin - 5.4f;

        }

        //staattinen metodi jolla rasvaprosentti voidaan laskea luomatta oliota
        static public float LaskeRasva2(float paino, float pituus, float ika, string sukupuoli)
        {
            float bmi = paino / (pituus * pituus);
            float sukupuolikerroin = 0;
            if(sukupuoli == "Mies")
            {
                sukupuolikerroin = 1;
            }
            float rasvaprosentti = 1.2f * bmi + 0.23f * ika - 10.8f * sukupuolikerroin - 5.4f;

            return rasvaprosentti;
        }
    }
}
