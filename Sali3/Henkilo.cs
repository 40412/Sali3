using System;
using System.Collections.Generic;
using System.Text;

namespace Sali3
{
    class Henkilo
    {
        // Määritellään kaikkien henkilöiden yhteiset ominaisuuudet (kentät)
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

        public string toString()
        {
            return this.etunimi + " " + this.sukunimi;
        }
    }
}
