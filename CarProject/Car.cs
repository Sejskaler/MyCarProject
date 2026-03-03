using System;

class Car
{
    private Class1()
    {
        string _brand;
        string _model;
        int _year;
        char _gear;
        double _odometer;
        string _fuelType;
        double _kmPrLiter;
        bool _engineActive;

        // Constructor
        public Car(string brand, string model, int year, char gear, double odometer, string fuelType, double kmPrLiter, bool engineActive)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            _odometer = odometer;
            _fueltype = fuelType;
            _kmPrLiter = kmPrLiter;
            _engineActive = engineActive;
        }

        // Read-only property - brand
        public string brand
        {
            get { return _brand; }
        }

        // Read-only property - model
        public string model
        {
            get { return _model; }
        }

        // Read-only property - year
        public int year
        {
            get { return _year; }
        }

        // Read-only property - gear
        public char gear
        {
            get { return _gear; }
        }

        // Read-only property - odometer
        public double odometer
        {
            get { return _odometer; }
        }

        // Read-only property - fuelType
        public string fuelType
        {
            get { return _fuelType; }
        }

        // Read-only property - kmPrLiter
        public double kmPrLiter
        {
            get { return _kmPrLiter; }
        }

        // Property with validation - engineActive
        public bool engineActive
        {
            get { return _engineActive; }
            set
            {
                if (engineActive == false)
                    _engineActive = true;

                else
                    _engineActive = false;
            }
        }

        // Method - Drive
        public double Drive(double odometer, bool engineActive)
        {
            while (true)
            {
                Console.Write("Distance: ");
                string distanceInput = Console.ReadLine();

                if (double.TryParse(distanceInput, out distance))
                    break;

                Console.WriteLine("Det er ikke et tal");
            }

            if (engineActive)
                _odometer += distance;
        }


        // Method - CalculateTripPrice
        public double CalculateTripPrice(string fuelType, double kmPrLiter, double fuelPrice, double distance)
        {
            Console.WriteLine("Vi kan ikke beregne en køretur uden distance");
//            while (_kmPrLiter == 0)
//            {
//                Console.WriteLine("Indtast over 0. \n Km per liter?");
//                string kmPrLiterInput = Console.ReadLine();
//                if (double.TryParse(kmPrLiterInput, out kmPrLiter))
//                    break;
//            }
//
            while (true)
            {
                Console.Write("Distance: ");
                string distanceInput = Console.ReadLine();

                if (double.TryParse(distanceInput, out distance))
                    break;

                Console.WriteLine("Det er ikke et nummer");
            }

            switch (fuelType.ToLower())
            {
                case "benzin":
                    fuelPrice = 13.49;
                    break;
                case "diesel":
                    fuelPrice = 12.29;
                    break;
                case "el":
                    fuelPrice = 1.12;
                    break;
                default:
                    Console.WriteLine("Fejl");
                    return 0;
            }

            double fuelNeeded = distance / kmPrLiter;
            double price = fuelNeeded * fuelPrice;
            return price;
        }

        // Method - ReadCarDetails
        public string ReadCarDetails()
        {
            // add navn osv.
            while (true)
            {
                Console.Write("Navn: ");
                string carOwner = (Console.ReadLine() ?? "").Trim();

                if (carOwner == "")
                    Console.WriteLine("Navn må ikke være tomt.");

                else
                    break;
            }

            Console.WriteLine("Brand: ");
            _brand = Console.ReadLine();

            Console.WriteLine("Model: ");
            _model = Console.ReadLine();

            Console.WriteLine("Aar: ");
            year = Console.ReadLine();
            yearInt = int.Parse(year);
            _year = yearInt;

            Console.WriteLine("Gear: ");
            _gear = char.Parse(Console.ReadLine());

            // kmPrLiter - loopet er brugt 3 gange
            while (true)
            {
                // få input fra bruger
                Console.Write("Km per liter: ");
                string kmPrLiterInput = Console.ReadLine();

                // tjek om input er double og output det til kmPrLiter hvis det er
                if (double.TryParse(kmPrLiterInput))
                {
                    // Opdater attribute og stop loopet hvis det er
                    _kmPrLiter = double.Parse(kmPrLiterInput);
                    break;
                }

                // hvis det ikke er en double, fortæl bruger
                Console.WriteLine("Det er ikke et nummer");
            }

            // odometer - samme som tidligere
            while (true)
            {
                Console.Write("Kilometerstand: ");
                string odometerInput = Console.ReadLine();

                if (double.TryParse(odometerInput))
                    _odometer = double.Parse(odometerInput);
                    break;

                Console.WriteLine("Det er ikke et nummer");
            }


            //gøres lidt anderledes med benz og diesel
            Console.WriteLine("benzin, diesel eller el?");
            string fuelType = Console.ReadLine();

            while (true)
            {
                // hvis det ikke er benzin/diesel/el
                if (fuelType.ToLower() != "benzin" && fuelType.ToLower() != "diesel" && fuelType.ToLower() != "el")
                {
                    Console.Write("skriv lige benzin, diesel eller el: ");
                    fuelType = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return carOwner;
        }

    }

}
    // To-do: lav en kort metode til at tænde og slukke bilen






