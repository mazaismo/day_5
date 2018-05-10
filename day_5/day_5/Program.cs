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
        }
       
        
    }
}
