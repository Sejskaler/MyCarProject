using System.Runtime.CompilerServices;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double braendstofspris = 0;
            double pris = 0;
            var bil = default((string brand, string model, int year, char gear, string braendstof, double kmPerLiter, double distance, int kilometerStand));

            bool LukProgram = false;

            Console.WriteLine("Velkommen til tidsplanlæggeren");

            while (!LukProgram)
            {
                Console.WriteLine("\nHvad vil du gøre?");
                Console.WriteLine("(S)kriv nye bildetaljer");
                Console.WriteLine("(D)rive");
                Console.WriteLine("(C)alculate Trip Price");
                Console.WriteLine("(P)alindrom");
                Console.WriteLine("(F)å bildetaljer");
                Console.WriteLine("(H)ele holdets bildetaljer"); //lav for loob der kører ReadCarDetails og derfra udskriver. Evt dict over navn + bil tuple
                var userChoice = Console.ReadLine();

                switch (userChoice.ToLower())
                {
                    case "a":
                        LukProgram = true;
                        Console.WriteLine("afslutter");
                        break;
                    case "d":
                        Console.WriteLine("Tilføj detaljer");
                        bil = ReadCarDetails();
                        break;
                    case "c":
                        Console.WriteLine("Kør");
                        Drive();
                        break;
                    case "p":
                        Console.WriteLine("er det et palindrom?");
                        IsPalindrome();
                        break;
                    case "f":
                        Console.WriteLine("få bildetaljer");
                        PrintCarDetails();
                        break;
                    case "h":
                        Console.WriteLine("Få hele holdets bildetaljer");
                        PrintAllTeamCars();
                        break;
                    default:
                        Console.WriteLine("Vælg venligst en");
                        return;

                }







                pris = BeregnPrisAfBraendstof(bil.braendstof, bil.kmPerLiter, braendstofspris, bil.distance);


                Console.WriteLine($"Brændstofstype: {bil.braendstof}, km/l: {bil.kmPerLiter}, oprindelig km stand: {bil.kilometerStand} ny kilometerstand {bil.kilometerStand + bil.distance} det koster: {Math.Round(pris)}");

                //try with string  format, it takes {0} etc. as the variables IN ORDER
                Console.WriteLine(String.Format("Brændstofudgifterne for {0} km er {1} DKK.", bil.distance, Math.Round(pris)));
                //Overskrift
                Console.WriteLine("Brændstof".PadRight(15) + "Distance".PadRight(15) + "Pris".PadRight(15));
                //add linjer
                Console.WriteLine(new string('-', 35));

                //rækker
                Console.WriteLine(bil.braendstof.PadRight(15) + bil.distance.ToString().PadRight(15) + Math.Round(pris).ToString().PadRight(15));

            }

            //lav beregningerne baseret på det der bliver parsed ind og return prisen
            static double BeregnPrisAfBraendstof(string braendstof, double kmperliter, double braendstofspris, double distance)
            {
                switch (braendstof.ToLower())
                {
                    case "benzin":
                        braendstofspris = 13.49;
                        break;
                    case "diesel":
                        braendstofspris = 12.29;
                        break;
                    case "el":
                        braendstofspris = 1.12;
                        break;
                    default:
                        Console.WriteLine("fejl");
                        return 0;
                }
                double fuelNeeded = distance / kmperliter;
                double Pris = fuelNeeded * braendstofspris;
                return Pris;

            }


            static (string brand, string model, int year, char gear, string braendstof, double kmPerLiter, double distance, int kilometerStand) ReadCarDetails()
            {
                string brand = "Toyota";
                string model = "Corolla";
                string year = "2020";
                int yearINT = 0;
                char gear = 'a';
                double kmPerLiter = 0;
                double distance = 0;
                int kilometerStand = 0;


                Console.WriteLine("Brand: " + Console.ReadLine());
                brand = Console.ReadLine();

                Console.WriteLine("Model: ");
                model = Console.ReadLine();

                Console.WriteLine("Aar: ");
                year = Console.ReadLine();
                yearINT = int.Parse(year);

                Console.WriteLine("gear: ");
                gear = char.Parse(Console.ReadLine());

                //kmperliter - loopet er brugt 3 gange
                while (true)
                {
                    //få input fra bruger
                    Console.Write("Km per liter: ");
                    string kmPerLiterInput = Console.ReadLine();

                    //tjek om input er double og output det til kmPerLiter hvis det er
                    if (double.TryParse(kmPerLiterInput, out kmPerLiter))
                    {
                        //Stop loopet hvis det er
                        break;
                    }
                    //hvis det ikke er en double, fortæl bruger
                    Console.WriteLine("Det er ikke et nummer");
                }

                //distance -- samme som tidligere
                while (true)
                {
                    Console.Write("distance: ");
                    string distanceInput = Console.ReadLine();

                    if (double.TryParse(distanceInput, out distance))
                        break;

                    Console.WriteLine("Det er ikke et nummer");
                }

                //kilometerstand -- samme som tidligere, men med int
                while (true)
                {
                    Console.Write("Kilometerstand: ");
                    string kilometerstandInput = Console.ReadLine();

                    if (int.TryParse(kilometerstandInput, out kilometerStand))
                        break;

                    Console.WriteLine("Det er ikke et nummer");
                }


                //gøres lidt anderledes med benz og diesel
                Console.WriteLine("benzin, diesel eller el?");
                string braendstof = Console.ReadLine();

                while (true)
                {
                    //hvis det ikke er benzin og det ikke er diesel
                    if (braendstof.ToLower() != "benzin" && braendstof.ToLower() != "diesel" && braendstof.ToLower() != "el")
                    {
                        Console.Write("skriv lige benzin, diesel eller el: ");
                        braendstof = Console.ReadLine();

                    }
                    else
                    {
                    }


                    return (brand, model, yearINT, gear, braendstof, kmPerLiter, distance, kilometerStand);



                    //($"Dit Bilmaerke er {brand} og det er modellen {model}. Den kommer fra år {year} og den kører med {gear} gear");
                }


            }
        }
        static void Drive()
        {

        }
        static void CalculateTripPrice()
        {

        }
        static void IsPalindrome()
        {

        }
        static void PrintCarDetails()
        {

        }
        static void PrintAllTeamCars()
        {

        }
    }
}
        