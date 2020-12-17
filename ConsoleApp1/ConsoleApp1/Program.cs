using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        public static int q=0;
        public static int punkty = 0;
        public static char[] odpowiedzi;
        public static char Litera()
        {
            Random losuj = new Random();
            int num = losuj.Next(0, 4);
            char litera = (char)('A' + num);
            return litera;
        }
        public static void Test()
        {
            punkty = 0;
           char[] LosoweOdpowiedzi = new char[q];
            for (int i = 0; i < q; i++)
            {
                LosoweOdpowiedzi[i] = Litera();
             //   Console.WriteLine(LosoweOdpowiedzi[i]);
                if (LosoweOdpowiedzi[i] == odpowiedzi[i])
                    {
                        punkty++;
                    }
            }
        }
 
        static void Main(string[] args)
        {
            ////zadanie 1

            int mmSum = 0;
            int ssSum = 0;
            int hhSum = 0;
            int nrSesji = 0;
            do
            {
                int mm = 0;
                int ss = 0;
                int hh = 0;
                nrSesji++;
                Console.WriteLine("Sesja " + nrSesji + "");
                Console.WriteLine("Podaj ile godzin sie uczyles?");
                hh = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ile minut sie uczyles?");
                mm = System.Int32.Parse(Console.ReadLine());
                Console.WriteLine("Podaj ile sekund sie uczyles?");
                ss = System.Int32.Parse(Console.ReadLine());
                mmSum += mm;
                ssSum += ss;
                hhSum += hh;
                if (ss > 60)
                {
                    mm++;
                    ss -= 60;
                }
                if (mm > 60)
                {
                    hh++;
                    mm -= 60;
                }
                if (ssSum > 60)
                {
                    mmSum++;
                    ssSum -= 60;
                }
                if (mmSum > 60)
                {
                    hhSum++;
                    mmSum -= 60;
                }
                Console.WriteLine("w tej sesji uczyles sie " + hh + " godzin " + mm + " minut " + ss + " sekund");
                Console.WriteLine("Czy wykonales kolejna sesje? y/n?");
            } while ((Console.ReadLine() == "y") || (Console.ReadLine() == "y"));
            Console.WriteLine("Lacznie uczyles sie " + hhSum + " godzin " + mmSum + " minut " + ssSum + " sekund, i wykonales lacznie sesji " + nrSesji + "");

            //Zadanie 2

            int numer = 0;
            {
                Console.WriteLine("Ile chcesz pytan? ");
                Console.WriteLine("Uwaga wprowadzone odpowiedzi musza byc wilekimi literami");
                q = Convert.ToInt16(Console.ReadLine());
                string[] questions = new string[q];
                odpowiedzi = new char[q];
                for (int i = 0; i < questions.Length; i++)
                {
                    numer = i + 1;
                    Console.WriteLine("Jaka jest odpowiedz na " + numer + " pytanie?");
                    odpowiedzi[i] = Convert.ToChar(Console.ReadLine());
                }
                Test();
                Console.WriteLine("Test pierwszy uzyskal " + punkty + "/" + questions.Length);
                Test();
                Console.WriteLine("Test drugi uzyskal " + punkty + "/" + questions.Length);

                Console.ReadKey();
            }
        }
    }
}
