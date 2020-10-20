using System;
using System.Collections.Generic;
using System.Linq;
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

            

        }
    }
}
