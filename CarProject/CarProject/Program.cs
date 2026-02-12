namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("benzin eller diesel?");
            string braendstof = Console.ReadLine();
            double kmPerLiter;
            int kilometerStand;

            //kmperliter
            while (true)
            {
                Console.Write("Km per liter: ");
                string kmPerLiterInput = Console.ReadLine();

                if (double.TryParse(kmPerLiterInput, out kmPerLiter))
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
            double pris = Beregning(kmPerLiter, braendstof);
            Console.WriteLine($"{pris}");
        }
            static double Beregning(double kmperliter, string braendstof)
        {
            if (braendstof.ToLower() == "diesel")
            {
                double braendstofpris = 12.29;
                return (braendstofpris * 2);
            }
            else if (braendstof.ToLower() == "benzin")
            {
                double braendstofpris = 13.49;
                return (braendstofpris * 1);
            }
            return 1;
        }
    }
}
