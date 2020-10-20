using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _5NIT_ConsApp_OefeningenLussen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Oefening 1
            /// 
            /// Oefening 1: 
            /// 
            Console.WriteLine("Oefening 1\n------------");
            Double balHoogte;
            Int16 botsAantal = 0;

            Console.Write("Vanaf welke hoogte laat je de bal vallen?     ");
            balHoogte = Convert.ToDouble(Console.ReadLine());

            do
            {
                balHoogte = balHoogte * 0.65;
                botsAantal++;
                Console.WriteLine($"De huidige hoogte op bots {botsAantal} is: {Math.Round(balHoogte,2)}");
            } while (balHoogte>0.1);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 2
            /// 
            /// Oefening 2: 
            /// 
            Console.WriteLine("Oefening 2");

            string Zin, omgezetteZin = "" ;
            Console.Write("Gelieve een zin in te voeren:     ");
            Zin = Console.ReadLine().ToLower();

            for (int teller = 0; teller < Zin.Length; teller++)
            {
                if (Zin.Substring(teller, 1).Contains("a") || Zin.Substring(teller, 1).Contains("e") || Zin.Substring(teller, 1).Contains("i") || Zin.Substring(teller, 1).Contains("o") || Zin.Substring(teller, 1).Contains("u"))
                {
                    omgezetteZin += Zin.Substring(teller, 1).ToUpper();
                }
                else
                {
                    omgezetteZin += Zin.Substring(teller, 1).ToLower();
                } 
            }

            Console.WriteLine(omgezetteZin);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 3
            /// 
            /// Oefening 3: 
            /// 
            Console.WriteLine("Oefening 3");

            const string wachtWoord = "2x4y";
            string invoer="";

            do
            {
                Console.Write("Gelieve jouw wachtwoord in te voeren:     ");
                invoer = Console.ReadLine();
            } while (wachtWoord != invoer);

            Console.WriteLine("Welkom, je bent ingelogd...");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 4
            /// 
            /// Oefening 4: 
            /// 
            Console.WriteLine("Oefening 4");

            for (int teller = 0; teller <= 50; teller+=2)
            {
                Console.Write(teller.ToString().PadLeft(6));
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 5
            /// 
            /// Oefening 5: 
            /// 
            Console.WriteLine("Oefening 5");

            for (int teller = 0; teller < 3; teller++)
            {
                Console.WriteLine("Ik vind programmeren ... leuk!");
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 6
            /// 
            /// Oefening 6: 
            /// 
            Console.WriteLine("Oefening 6");

            for (int teller = 2000; teller <= 2010; teller++)
            {
                Console.Write(teller.ToString().PadLeft(7));
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 7
            /// 
            /// Oefening 7: 
            /// 
            Console.WriteLine("Oefening 7");

            Console.Write("Hoeveel keer wil je 'Hallo wereld' afdrukken?     ");
            Int16 aantalKeer = Convert.ToInt16(Console.ReadLine());

            for (int teller = 0; teller < aantalKeer; teller++)
            {
                Console.WriteLine("Hallo wereld!");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 8
            /// 
            /// Oefening 8: 
            /// 
            Console.WriteLine("Oefening 8");

            Int16 ingevoerdGetal;

            for (int teller = 1; teller < 6; teller++)
            {
                Console.Write($"Geef getal {teller} in:     ");
                ingevoerdGetal = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine($"Het ingevoerde getal is: {ingevoerdGetal}");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 9
            /// 
            /// Oefening 9: 
            /// 
            Console.WriteLine("Oefening 9");

            Int16 ingevoerdGetal9;
            Int32 som = 0;

            for (int teller = 1; teller < 6; teller++)
            {
                Console.Write($"Geef getal {teller} in:     ");
                ingevoerdGetal9 = Convert.ToInt16(Console.ReadLine());

                som += ingevoerdGetal9;
            }

            Console.WriteLine($"De som van alle getallen is: {som}");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 10
            /// 
            /// Oefening 10: 
            /// 
            Console.WriteLine("Oefening 10");

            Int16 start, einde;
            Console.Write("Gelieve de startwaarde in te vullen:     ");
            start = Convert.ToInt16(Console.ReadLine());

            Console.Write("Gelieve de eindwaarde in te vullen:     ");
            einde = Convert.ToInt16(Console.ReadLine());

            for (int teller = start; teller <= einde; teller++)
            {
                Console.Write(teller.ToString().PadLeft(8));
            }
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 11
            /// 
            /// Oefening 11: 
            /// 
            Console.WriteLine("Oefening 11");

            Int16 ingevoerdGetal10;

            do
            {
                Console.Write("Gelieve een getal in te geven...     ");
                ingevoerdGetal10 = Convert.ToInt16(Console.ReadLine());
            } while (ingevoerdGetal10 != 0);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 12
            /// 
            /// Oefening 12: 
            /// 
            Console.WriteLine("Oefening 12");

            string ingevoerdWoord;

            do
            {
                Console.Write("Gelieve een woord in te vullen (eindigen doe je met 'stop')");
                ingevoerdWoord = Console.ReadLine();
                Console.WriteLine(ingevoerdWoord.ToUpper());
            } while (ingevoerdWoord != "stop");

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 13
            /// 
            /// Oefening 13: 
            /// 
            Console.WriteLine("Oefening 13");

            Int16 ingevoerdGetal13;
            Console.Write("Gelieve een getal in te vullen:     ");
            ingevoerdGetal13 = Convert.ToInt16(Console.ReadLine());

            while (ingevoerdGetal13 > 10)
            {
                ingevoerdGetal13 -= 5;
                Console.Write(ingevoerdGetal13.ToString().PadLeft(6));
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Oefening 14
            /// 
            /// Oefening 14: 
            /// 
            Console.WriteLine("Oefening 14");


            Console.ReadKey();
            Console.Clear();
            #endregion



        }
    }
}
