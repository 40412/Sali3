using System;
using System.Collections.Generic;
using System.Text;

// ulkoinen nimiavaruus Henkilosto
namespace Henkilosto
{
    //Trainer-luokka perii Henkilo-luokan ominaisuudet
    class Trainer : Sali3.Henkilo
    {
        protected string ala;
        protected string puhelin;
        protected string email;

        public Trainer(string enimi, string snimi, string katu, string postinro, string ptoimipkka, string ala, string puh, string email)
        {
            this.etunimi = enimi;
            this.sukunimi = snimi;
            this.osoite = katu;
            this.postinumero = postinro;
            this.postitoimipaikka = ptoimipkka;
            this.ala = ala;
            this.puhelin = puh;
            this.email = email;
        }

        public void naytaTrainer()
        {
            Console.WriteLine("Etunimi on " + this.etunimi);
            Console.WriteLine("Sukunimi on " + this.sukunimi);
            Console.WriteLine("Osoite on " + this.osoite);
            Console.WriteLine("Postinumero on " + this.postinumero);
            Console.WriteLine("Postitoimipaikka on " + this.postitoimipaikka);
            Console.WriteLine("Ala on " + this.ala); 
            Console.WriteLine("Puhelinnumero on " + this.puhelin);
            Console.WriteLine("Sähköposti on " + this.email);
        }
    }
  
    
}
