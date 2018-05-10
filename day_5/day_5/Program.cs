using System;

namespace day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. GATAVS
            Console.WriteLine("Ievadiet lūdzu savu vārdu un uzvārdu");
            string name;
            name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadLine();
            */

            /* OTRAIS PABEIGTS
             * 
            Console.WriteLine("Kāds šobrīid ir gads?");
            int gads = 2;
            string ievade = Console.ReadLine();
            
            gads = Convert.ToInt16(ievade);
            Console.WriteLine(gads);
            Console.WriteLine("Kurā gadā jūs piedzimāt");
            int dz_gads = 9;
            string ievade2 = Console.ReadLine();
            dz_gads = Convert.ToInt16(ievade2);
            Console.Write("tavs vecums ir " );
            Console.Write(gads - dz_gads);

            Console.ReadLine();
            */

            /* TREŠAIS PABEIGTS (lai programma strādātu, vajag izmantot funkcijas "Laukums" un "Diametrs" 
             Console.WriteLine("Ievadiet riņķa līnijas radiusu");
             string enter = Console.ReadLine();
             int radiuss = Convert.ToInt16(enter);
             int a = Diametrs(radiuss);
             double b = Laukums(radiuss);
             Console.WriteLine("Riņķa diametrs ir " + a);
             Console.WriteLine("Riņķa laukums ir " + b);

             Console.ReadLine();
             */

            string ievade = Console.ReadLine();
            int number = Convert.ToInt16(ievade);
            int skaitlis;
            int rezultats = Abc(number);
            Console.WriteLine("Mans skaitlis ir " + rezultats);

            Console.ReadLine();

        }
        static int Abc(int number)
        {
            
            return number;
        }


        /*
        static int Diametrs(int radiuss)
        {
            int lauks = radiuss * 2;

            return lauks;
        }
        static double Laukums(int radiuss)
        {
            double pi = 3.14;
            double lauks = radiuss * 2 * pi;

            return lauks;
        
        }
        */
    }
}
