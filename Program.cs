using System;

namespace Returverdier
{
    internal class Program
    {

       static int tall1 = 3;
       static int tall2 = 4;
       static string ingenTing = "Denne metoden returnerer ingenting";

       static void Main(string[] args)
        {
            var toTall = TallSum(tall1, tall2);
            Console.WriteLine(toTall);
            var ikkeNoe = Nada(ingenTing);
            Console.WriteLine(ikkeNoe);
            
         
        }
        static int TallSum(int tall1, int tall2)
        {
            return tall1 + tall2;
        }
        static string Nada(string ingenTing)
        {
            return ingenTing;
        }
       

    }
}
