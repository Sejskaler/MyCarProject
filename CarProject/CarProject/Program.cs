using System.Runtime.CompilerServices;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double braendstofspris = 0;
            double pris = 0;

            //hvis det er, så beregn prisen


            var bil = ReadCarDetails();


            pris = BeregnPrisAfBraendstof(bil.braendstof, bil.kmPerLiter, braendstofspris, bil.distance);

            /*//skriv det hele ud
            Console.WriteLine($"Brændstofstype: {braendstof}, km/l: {kmPerLiter}, oprindelig km stand: {kilometerStand} ny kilometerstand {kilometerStand + distance} det koster: {Math.Round(pris)}");

            //try with string  format, it takes {0} etc. as the variables IN ORDER
            Console.WriteLine(String.Format("Brændstofudgifterne for {0} km er {1} DKK.", distance, Math.Round(pris)));
            //Overskrift
            Console.WriteLine("Brændstof".PadRight(15) + "Distance".PadRight(15) + "Pris".PadRight(15));
            //add linjer
            Console.WriteLine(new string('-', 35));

            //rækker
            Console.WriteLine(braendstof.PadRight(15) + distance.ToString().PadRight(15) + Math.Round(pris).ToString().PadRight(15));
            */
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


        static (string brand, string model, int year, char gear, string braendstof, double kmPerLiter, double distance) ReadCarDetails()
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
                    //så skriv det lige igen
                    Console.Write("skriv lige benzin, diesel eller el: ");
                    braendstof = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Prøv lige at skrive benzin, diesel eller el");
                }


                return (brand, model, yearINT, gear, braendstof, kmPerLiter, distance);



                //($"Dit Bilmaerke er {brand} og det er modellen {model}. Den kommer fra år {year} og den kører med {gear} gear");
            }

            static void ReadCarDetails()
            {

            }
        }
    }
}
        