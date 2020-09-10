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

            Jasen jasen1 = new Jasen("Kekke", "Kovalainen", "Kotikatu 4", "21290", "Rusko", "2332", "Mies");
            jasen1.naytaJasen();

        }
    }
}
