
using System;

namespace Sali3
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo henkilo1 = new Henkilo();
            Console.WriteLine("testataan henkilo-olion luontia");
            Console.WriteLine(henkilo1.toString());
            Henkilo henkilo2 = new Henkilo("Jorma", "Kekkuli", "Kivitie 2", "21200", "Raisio");
            Console.WriteLine(henkilo2.toString());
            henkilo1.naytaHenkilo();
            henkilo2.naytaHenkilo();

            

            Console.WriteLine("");
            Console.WriteLine("");

            Henkilosto.Trainer trainer = new Henkilosto.Trainer("Kaisa", "Kovalainen", "Jokikatu 10", "21290", "Rusko", "Lihaskunto", "0452454977", "kaisa.kovis@gmail.com");
            trainer.naytaTrainer();

            Console.WriteLine("");
            Console.WriteLine("");

            //testataan punnitus-olion toiminta

            Punnitus punnitus = new Punnitus("10.9.2020", 71.5f, 1.71f);
            punnitus.naytaPunnitus();


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
        }
    }
}
