namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance;
            double kmPerLiter;
            int kilometerStand;
            double braendstofspris;
            double pris = 0;

            //kmperliter
            while (true)
            {
                Console.Write("Km per liter: ");
                string kmPerLiterInput = Console.ReadLine();

                if (double.TryParse(kmPerLiterInput, out kmPerLiter))
                    break;

                Console.WriteLine("Det er ikke et nummer");
            }
            //distance
            while (true)
            {
                Console.Write("distance: ");
                string distanceInput = Console.ReadLine();

                if (double.TryParse(distanceInput, out distance))
                    break;

                Console.WriteLine("Det er ikke et nummer");
            }
            //kilometerstand
            while (true)
            {
                Console.Write("Kilometerstand: ");
                string kilometerstandInput = Console.ReadLine();

                if (int.TryParse(kilometerstandInput, out kilometerStand))
                    break;

                Console.WriteLine("Det er ikke et nummer");
            }

            Console.Write("benzin eller diesel?");
            string braendstof = Console.ReadLine();

            while (true)
            {
                if (braendstof.ToLower() != "benzin" && braendstof.ToLower() != "diesel")
                {
                    Console.WriteLine("skriv lige benzin eller diesel");
                    braendstof = Console.ReadLine();
                }
                else
                {             
                    //udregn pris
                    if (braendstof.ToLower() == "diesel")
                    {
                        braendstofspris = 12.29;
                        pris = Beregning(kmPerLiter, braendstofspris, distance);
                    }
                    else if (braendstof.ToLower() == "benzin")
                    {
                        braendstofspris = 13.49;
                        pris = Beregning(kmPerLiter, braendstofspris, distance);
                    }
                    else
                    {
                        Console.WriteLine("fejl");
                    }
                    break; 
                }

            }
            Console.WriteLine($"Brændstofstype: {braendstof}, km/l: {kmPerLiter}, oprindelig km stand: {kilometerStand} ny kilometerstand {kilometerStand + distance} det koster: {pris}");
        }


            static double Beregning(double kmperliter, double braendstofpris, double distance)
            {
                double fuelNeeded = distance / kmperliter;
                double Pris = fuelNeeded * braendstofpris;
                return Pris;

            }
        }
    }

