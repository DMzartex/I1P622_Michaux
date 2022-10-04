using System;

namespace I1P622_Michaux // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continu = 1;

            Feu feu_1 = new Feu("0010", 1, "éteint");
            Feu feu_2 = new Feu("0011", 2, "allumé");

            Console.WriteLine("Etat des feux :");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(feu_1.afficheFeu());
            Console.WriteLine(feu_2.afficheFeu());

            Console.WriteLine("Changement d'état :");
            Console.WriteLine("-----------------------------");
            
            for(int n = 0; n < 7; n++)
            {
                feu_1.changeFeu();
                Console.WriteLine(feu_1.afficheFeu());

            }

            Console.WriteLine("Feu clignotant :");
            Console.WriteLine("----------------------------");

            for (int n = 0; n < 7; n++)
            {
                feu_2.changeFeu();
                Console.WriteLine(feu_2.afficheEtatFeu());
            }

            Console.ReadLine();
        }
    }
}