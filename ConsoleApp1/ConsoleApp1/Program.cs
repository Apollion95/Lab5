using System;
using System.Text;

namespace ConsoleApp1
{
    public enum Proces
    {
        Zapelnianie = 1,
        Zwalnianie = 2
    }
    public class Bufor
    {
        public double dane = 0;
        public Proces proces;
        public void Wczytuj()
        {
            if (dane < 50)
            {
                Console.WriteLine("Nowy Proces Zapelnianie "+dane);
                proces = Proces.Zapelnianie;
            }
            else
            {
                Console.WriteLine("Kolejka jest pelna");
            }
                
            
        }
        public void Zapisuj()
        {
            if (dane > 0)
            {
                Console.WriteLine("Nowy Proces Zwalnianie "+dane);
                proces = Proces.Zwalnianie;
            }
            else
            {
                Console.WriteLine("Kolejka jest pusta");
            }
        }
        public void Cykl()
        {
            if (proces==Proces.Zapelnianie)
            {
                if (dane < 50)
                {
                    dane++;
                }
                else
                {
                    Console.WriteLine("Kolejka jest pelna");
                }
            }

            if (proces == Proces.Zwalnianie)
            {
                if (dane > 0)
                {
                    dane--;
                }
                else
                {
                    Console.WriteLine("Kolejka jest pusta");
                }
                   
                
            }

        }

    }

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
               Console.WriteLine("Odpowiedz "+i+" "+LosoweOdpowiedzi[i]);
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
            int wynik = 0;
            {
                Console.WriteLine("Ile chcesz pytan? ");
                q = Convert.ToInt16(Console.ReadLine());
                string[] pytania = new string[q];
                odpowiedzi = new char[q];
                for (int i = 0; i < pytania.Length; i++)
                {
                    numer = i + 1;
                    Console.WriteLine("Jaka jest odpowiedz na " + numer + " pytanie?");
                    odpowiedzi[i] = Convert.ToChar(Console.ReadLine());
                    odpowiedzi[i] = char.ToUpper(odpowiedzi[i]);
                }
                Console.WriteLine("Test pierwszy miał ponizsze odpowiedzi");
                Test();
                wynik = punkty * 100 / pytania.Length;
                Console.WriteLine("Test pierwszy uzyskal " + wynik + "%");


                Console.WriteLine("Test drugi miał ponizsze odpowiedzi");
                Test();
                wynik = punkty * 100 / pytania.Length;
                Console.WriteLine("Test drugi uzyskal " + wynik + "%");

                Console.WriteLine("Test trzeci miał ponizsze odpowiedzi");
                Test();
                wynik = punkty * 100 / pytania.Length;
                Console.WriteLine("Test trzeci uzyskal " + wynik + "%");
            }

            //zadanie 3 Testy

            var x = new Bufor();
            x.Wczytuj();
            x.Cykl();
            x.Wczytuj();
            x.Cykl(); 
            x.Zapisuj();
            x.Cykl();
            x.Zapisuj();
            x.Cykl();
            x.Zapisuj();
            x.Cykl();
            x.Zapisuj();
            x.Cykl();
            for (int i = 0; i < 55; i++) //po 50 powinno poinformowac ze kolejka jest pelna
            {
                x.Wczytuj();
                x.Cykl();
            }
            for (int i = 0; i < 55; i++) //po0 powinno poinformowac ze kolejka jest pusta
            {
                x.Zapisuj();
                x.Cykl();
            }



        }
    }
}
