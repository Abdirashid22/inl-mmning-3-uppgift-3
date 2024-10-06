using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många dagar vill du hyra bilen");
            int antaldagar=int.Parse(Console.ReadLine());
            Console.Write("Hur många kilometer ska du köra? ");
            int antalKilometer = int.Parse(Console.ReadLine());

            int totalKostnad = 300 + ((antaldagar - 1) * 500) + (antalKilometer * 1);

            Console.WriteLine("Den totala kostnaden för hyran är " + totalKostnad + " kr");

        }
    }
}
