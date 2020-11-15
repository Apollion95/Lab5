using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////zadanie 1
            int mm = 0;
            int ss = 0;
            int mmSum = 0;
            int ssSum = 0;
            int nrSesji = 0;
            do
            {
                nrSesji++;
                Console.WriteLine("Sesja " + nrSesji + "");
                Console.WriteLine("Podaj ile minut sie uczyles?");
                mm = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ile sekund sie uczyles?");
                ss = System.Int32.Parse(Console.ReadLine());
                mmSum += mm;
                ssSum += ss;
                Console.WriteLine("Czy wykonales kolejna sesje? y/n?");
            } while ((Console.ReadLine() == "y") || (Console.ReadLine() == "y"));
            Console.WriteLine("Lacznie uczyles sie " + mmSum + " minut " + ssSum + " sekund, i wykonales lacznie sesji " + nrSesji + "");

            //Zadanie 2



            int a = 0;
            Console.WriteLine("Wprowadz ilosc pytan ");
            a = int.Parse(Console.ReadLine());
            string[] tablicaOdpowiedzi = new string[a];
            for (int i = 0; i < tablicaOdpowiedzi.Length; i++)
            {
                Console.WriteLine("wpisz odpowiedz nr " + a + " A/B/C/D");
                tablicaOdpowiedzi[i] = Console.ReadLine();

            }
            string[] tablicaOdp1 = new string[a]; //zakladamy ze odpowiedzi jest 10
   
        }
        }
}
