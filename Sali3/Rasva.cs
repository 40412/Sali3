using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        static public float Ika(string syntymapaiva)
        {
            CultureInfo cultureInfo = new CultureInfo("fi-FI");
            DateTime nollavuosi = new DateTime(1, 1, 1);
            DateTime spaiva = DateTime.Parse(syntymapaiva, cultureInfo);
            DateTime tanaan = DateTime.Now;
            TimeSpan ero = tanaan - spaiva;
            float ika = (nollavuosi + ero).Year - 1;
            return ika;
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

        static public float Painoindeksi(float pituus, float paino)
        {
            if (pituus > 3)
            {
                pituus = pituus / 100;
            }
            if (pituus > 0.5 && pituus < 3 && paino > 20 && paino < 250)
            {
                return paino / (pituus * pituus);
            }
            else
            {
                Console.WriteLine("Virheellinen pituus tai paino");
                return 0;
            }
        }

        //staattinen metodi jolla rasvaprosentti voidaan laskea luomatta oliota
        static public float LaskeRasva2(float paino, float pituus, float ika, string sukupuoli)
        {
            float bmi = Painoindeksi(pituus, paino);
            float sukupuolikerroin = 0;
            if(sukupuoli == "Mies" || sukupuoli == "mies")
            {
                sukupuolikerroin = 1;
            }
            float aikuisenrasvaprosentti = 1.2f * bmi + 0.23f * ika - 10.8f * sukupuolikerroin - 5.4f;
            float lapsenrasvaprosentti = (1.51f * bmi) - (0.70f * ika) - (3.6f * sukupuolikerroin) + 1.4f;
            if (ika < 16)
            {
                return lapsenrasvaprosentti;
            }
            else
            {
                return aikuisenrasvaprosentti;
            }
        }
    }
}
