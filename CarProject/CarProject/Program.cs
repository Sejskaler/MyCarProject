using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FuelPrice = 0.0;
            double Price = 0.0;
            double Distance = 0.0;

            Car bil1 = new Car("", "", 0, '\0', 0.0, "", 0.0, false);

            //string bruger det samme som vores tuple
            //Dictionary<string, (string navn, string brand, string model, int year, char gear, string braendstof, double kmPerLiter, double distance, int kilometerStand)> biler = new Dictionary<string, (string, string, string, int, char, string, double, double, int)>(StringComparer.OrdinalIgnoreCase);
            

            //initialiser første bil
            //var bil = ReadCarDetails();

            // Add bilen til vores liste med bildetaljer
            //biler[bil.navn] = bil;
            bool LukProgram = false;

            Console.WriteLine("Velkommen til Bilprogrammet");

            while (!LukProgram)
            {
                Console.WriteLine("\nHvad vil du gøre?");
                Console.WriteLine("(S)kriv nye bildetaljer");
                Console.WriteLine("(D)rive");
                Console.WriteLine("(C)alculate Trip Price");
                Console.WriteLine("(P)alindrom");
                Console.WriteLine("(F)å bildetaljer om senest tilføjede");
                Console.WriteLine("(H)ele holdets bildetaljer"); //lav for loob der kører ReadCarDetails og derfra udskriver. Evt dict over navn + bil tuple
                var userChoice = Console.ReadLine();

                switch (userChoice.ToLower())
                {
                    case "a":
                        LukProgram = true;
                        Console.WriteLine("afslutter");
                        break;
                    case "s":
                        bil = ReadCarDetails();

                        // Add or overwrite (simplest)
                        biler[bil.navn] = bil;

                        Console.WriteLine($"Gemt bil for {bil.navn}.");
                        break;
                    case "c":
                        Console.WriteLine("Calc trip price");
                        CalculateTripPrice(bil.braendstof, bil.kmPerLiter, braendstofspris);
                        break;
                    case "d":
                        Console.WriteLine("Kør");
                        Console.WriteLine(Odometer);
                        bil.kilometerStand = Drive(Odometer, true);
                        Console.WriteLine(Odometer);
                        break;
                    case "p":
                        Console.WriteLine("er det et palindrom?");
                        bool palindromeTest = IsPalindrome(Odometer);
                        Console.WriteLine(palindromeTest);
                        break;
                    case "f":
                        Console.WriteLine("få bildetaljer");
                        PrintCarDetails(FuelType, KmPerLiter, Odometer, distance);
                        break;
                    case "h":
                        Console.WriteLine("Få hele holdets bildetaljer");
                        PrintAllTeamCars(biler);
                        break;
                    default:
                        Console.WriteLine("Vælg venligst en");
                        return;

                }




            }


        }
        static bool IsPalindrome(int km)
        {
            string kmString = km.ToString();
            char[] kmPalindrome = kmString.ToCharArray();
            Array.Reverse(kmPalindrome);
            string kmStringReversed = new string(kmPalindrome);
            if (kmString == kmStringReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintCarDetails(string fuelType, double kmPrLiter, double odometer, double distance)
        {
        Console.WriteLine($"Brændstofstype: {fuelType}, km/l: {kmPrLiter}, oprindelig km stand: {Odometer} ny kilometerstand {odometer + distance} det koster: {Math.Round(CalculateTripPrice(fuelType, kmPerLiter, 0))}");
        }


        static void PrintAllTeamCars(Dictionary<string, (string navn, string brand, string model, int year, char gear, string braendstof, double kmPerLiter, double distance, int kilometerStand)> biler)
        {
            foreach (var bil in biler)
            {
                Console.WriteLine($"\n=== {bil.Key} ===");
                Console.WriteLine(bil.Value);
            }
        }
    }
}
        