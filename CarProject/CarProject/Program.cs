using System.Runtime.CompilerServices;

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
            Console.Write("benzin eller diesel?");
            string braendstof = Console.ReadLine();

            while (true)
            {
                //hvis det ikke er benzin og det ikke er diesel
                if (braendstof.ToLower() != "benzin" && braendstof.ToLower() != "diesel")
                {
                    //så skriv det lige igen
                    Console.WriteLine("skriv lige benzin eller diesel");
                    braendstof = Console.ReadLine();
                }
                else
                //hvis det er, så beregn prisen
                {             
                    //udregn pris
                    if (braendstof.ToLower() == "diesel")
                    {
                        braendstofspris = 12.29;
                        //benyt funktionen Beregning
                        pris = Beregning(kmPerLiter, braendstofspris, distance);
                    }
                    else if (braendstof.ToLower() == "benzin")
                    {
                        braendstofspris = 13.49;
                        pris = Beregning(kmPerLiter, braendstofspris, distance);
                    }
                    else
                    {
                        //det her sker aldrig, men hvis det gør, så skriv en fejl. Det vil den gøre for evigt, det her bør egentligt få et break og returne nothing for ikke at få et inf. loop
                        Console.WriteLine("fejl");
                    }
                    //hvis det har lykkedes os at udregne, så break
                    break; 
                }

            }
            //skriv det hele ud
            Console.WriteLine($"Brændstofstype: {braendstof}, km/l: {kmPerLiter}, oprindelig km stand: {kilometerStand} ny kilometerstand {kilometerStand + distance} det koster: {pris}");

            //try with string  format, it takes {0} etc. as the variables IN ORDER
            Console.WriteLine(String.Format("Brændstofudgifterne for {0} km er {1} DKK.", distance, pris));

        }

        //lav beregningerne baseret på det der bliver parsed ind og return prisen
            static double Beregning(double kmperliter, double braendstofpris, double distance)
            {
                double fuelNeeded = distance / kmperliter;
                double Pris = fuelNeeded * braendstofpris;
                return Pris;

            }

        
        }
    }
