using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Punnitus
    {
        protected string paiva;
        protected float paino;
        protected float pituus;

        public Punnitus(string paiva, float paino, float pituus)
        {
            this.paiva = paiva;
            this.paino = paino;
            this.pituus = pituus;
        }

        public void naytaPunnitus()
        {
            Console.WriteLine("Punnituspäivä: " + this.paiva);
            Console.WriteLine("Paino: " + this.paino);
            Console.WriteLine("Pituus: " + this.pituus);
        }

        public float Painoindeksi()
        {
            return paino / (pituus * pituus);
        }

        //public float RasvaprosenttiTytto()
        //{
        //    return 
        //}

        //public float RasvaprosenttiPoika()
        //{
        //    return 
        //}

        //public float RasvaprosenttiMies()
        //{
        //    return
        //}

        //public float RasvaprosenttiNainen()
        //{
        //    return 
        //}

    }
}
