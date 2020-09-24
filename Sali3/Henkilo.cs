using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Henkilo
    {
        // Määritellään kaikkien henkilöiden yhteiset ominaisuudet (kentät)
        protected string etunimi;
        protected string sukunimi;
        protected string osoite;
        protected string postinumero;
        protected string postitoimipaikka;
        


        // Olionmuodostimet (konstruktorit)
        public Henkilo()
        {
            this.etunimi = "etunimi";
            this.sukunimi = "sukunimi";
            this.osoite = "N/A";
            this.postinumero = "N/A";
            this.postitoimipaikka = "N/A";
            
        }

        //kaikilla parametreillä
        public Henkilo(string etunmi, string sukunmi, string katu, string postinro, string ptoimipkka)
        {
            this.etunimi = etunmi;
            this.sukunimi = sukunmi;
            this.osoite = katu;
            this.postinumero = postinro;
            this.postitoimipaikka = ptoimipkka;
        }

        //Metodeja testaukseen

        public string toString()
        {
            return this.etunimi + ", " + this.sukunimi + ", " + this.osoite + ", " + this.postinumero + ", " + this.postitoimipaikka;
        }

        public void naytaHenkilo()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi); 
            Console.WriteLine("Osoite on " + this.osoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);

        }
    }
    class Jasen : Henkilo
    {
        // erityisominaisuudet, joita ei ole Henkilo-luokassa
        protected string jasenid;
        protected string sukupuoli;
        protected string syntymaAika;

        

        // Muodostin kaikilla parametreilla

        public Jasen(string etu, string suku, string katu, string pnro, string ptoimpkka, string jasenid, string sukupuoli, string synaika)
        {
            this.etunimi = etu;
            this.sukunimi = suku;
            this.osoite = katu;
            this.postinumero = pnro;
            this.postitoimipaikka = ptoimpkka;
            this.jasenid = jasenid;
            this.sukupuoli = sukupuoli;
            this.syntymaAika = synaika;
        }

        public string SyntymaAika
        {
            get { return this.syntymaAika; }
        }

        public string Sukupuoli
        {
            get { return this.sukupuoli; }
        }

        public void naytaJasen()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Osoite on " + this.osoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
            Console.WriteLine("Jäsennumero on " + this.jasenid);
            Console.WriteLine("Sukupuoli on " + this.sukupuoli);
            Console.WriteLine("Syntymäaika on " + this.syntymaAika);
            
        }

    }
}
