
using System;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Kaisa", "Kovalainen", "Jokikatu 10", "21290", "Rusko", "Lihaskunto", "0452454977", "kaisa.kovis@gmail.com");
            trainer.naytaTrainer();

            Console.WriteLine("");
            Console.WriteLine("");
            

            Rasva rasvaprosentti = new Rasva();
            rasvaprosentti.ika = "26";
            rasvaprosentti.sukupuoli = "Nainen";
            Console.WriteLine(rasvaprosentti.Rasvaprosentti(1.63f, 50));

            Console.WriteLine("");
            Console.WriteLine("");

            //testataan staattista rasvaprosentin laskumetodia

            Console.WriteLine("Rasvaprosentti: " + Rasva.LaskeRasva2(71.5f, 1.71f, 58f, "Mies"));
            Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(Rasva.Ika("1.11.1994"));
            Console.WriteLine(Rasva.Painoindeksi(168, 400));
            Console.WriteLine(Rasva.LaskeRasva2(55, 166, 26, "nainen"));

            //testataan iän laskeminen jäsen-oliosta


            Jasen jasen = new Jasen("Jasmin", "Fränti", "Kunnaankatu 17", "21200", "Raisio", "100", "nainen", "4.10.1994");
            Punnitus pun = new Punnitus("1.11.2020", 55, 165);

            float jika = Rasva.Ika(jasen.SyntymaAika);
            float jbmi = Rasva.Painoindeksi(pun.Pituus, pun.Paino);
            float jrasva = Rasva.LaskeRasva2(pun.Paino, pun.Pituus, Rasva.Ika(jasen.SyntymaAika), jasen.Sukupuoli);
            Console.WriteLine("Henkilö: ");
            jasen.naytaJasen();
            Console.WriteLine("BMI: " + jbmi);
            Console.WriteLine("Rasvaprosentti: " + jrasva);
            Console.WriteLine("");
            Console.WriteLine("");

            
        }
    }
}
