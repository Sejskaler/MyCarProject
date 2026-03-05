using System;

class Car
{
    private class Car()
    {
        private string _brand;
        private string _model;
        private int _year;
        private char _gear;
        private double _odometer;
        private string _fuelType;
        private double _kmPrLiter;
        private bool _engineActive;

        // Constructor
        public Car(string brand, string model, int year, char gear, double odometer, string fuelType, double kmPrLiter, bool engineActive)
        {
            _brand = brand;
            _model = model;
            _year = year;
            _gear = gear;
            _odometer = odometer;
            _fuelType = fuelType;
            _kmPrLiter = kmPrLiter;
            _engineActive = engineActive;
        }

        // Read-only property - brand
        public string Brand
        {
            get { return _brand; }
        }

        // Read-only property - model
        public string Model
        {
            get { return _model; }
        }

        // Read-only property - year
        public int Year
        {
            get { return _year; }
        }

        // Read-only property - gear
        public char Gear
        {
            get { return _gear; }
        }

        // Read-only property - odometer
        public double Odometer
        {
            get { return _odometer; }
        }

        // Read-only property - fuelType
        public string FuelType
        {
            get { return _fuelType; }
        }

        // Read-only property - kmPrLiter
        public double KmPrLiter
        {
            get { return _kmPrLiter; }
        }

        // Property with validation - engineActive
        public bool EngineActive
        {
            get { return _engineActive; }
            set
            {
                if (EngineActive == false)
                    _engineActive = true;

                else
                    _engineActive = false;
            }
        }

        // Method - Drive
        public double Drive(double Odometer, bool EngineActive, double Distance)
        {
            while (true)
            {
                Console.Write("Distance: ");
                string DistanceInput = Console.ReadLine();

                if (double.TryParse(DistanceInput, out Distance))
                    break;

                Console.WriteLine("Det er ikke et tal");
            }

            if (EngineActive)
                _odometer += distance;
          
        }


        // Method - CalculateTripPrice
        public double CalculateTripPrice(string FuelType, double KmPrLiter, double FuelPrice, double distance)
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

            switch (FuelType.ToLower())
            {
                case "benzin":
                    FuelPrice = 13.49;
                    break;
                case "diesel":
                    FuelPrice = 12.29;
                    break;
                case "el":
                    FuelPrice = 1.12;
                    break;
                default:
                    Console.WriteLine("Fejl");
                    return 0;
            }

            double FuelNeeded = distance / KmPrLiter;
            double price = FuelNeeded * FuelPrice;
            return price;
        }

        // Method - ReadCarDetails
        public string ReadCarDetails()
        {
            // add navn osv.
            while (true)
            {
                Console.Write("Navn: ");
                string CarOwner = (Console.ReadLine() ?? "").Trim();

                if (CarOwner == "")
                    Console.WriteLine("Navn må ikke være tomt.");

                else
                    break;
            }

            Console.WriteLine("Brand: ");
            _brand = Console.ReadLine();

            Console.WriteLine("Model: ");
            _model = Console.ReadLine();

            Console.WriteLine("Aar: ");
            _year = Console.ReadLine();
            yearInt = int.Parse(_year);
            _year = yearInt;

            Console.WriteLine("Gear: ");
            _gear = char.Parse(Console.ReadLine());

            // kmPrLiter - loopet er brugt 3 gange
            while (true)
            {
                // få input fra bruger
                Console.Write("Km per liter: ");
                string KmPrLiterInput = Console.ReadLine();

                // tjek om input er double og output det til kmPrLiter hvis det er
                if (double.TryParse(KmPrLiterInput))
                {
                    // Opdater attribute og stop loopet hvis det er
                    _kmPrLiter = double.Parse(KmPrLiterInput);
                    break;
                }

                // hvis det ikke er en double, fortæl bruger
                Console.WriteLine("Det er ikke et nummer");
            }

            // odometer - samme som tidligere
            while (true)
            {
                Console.Write("Kilometerstand: ");
                string OdometerInput = Console.ReadLine();

                if (double.TryParse(OdometerInput))
                    _odometer = double.Parse(OdometerInput);
                    break;

                Console.WriteLine("Det er ikke et nummer");
            }


            //gøres lidt anderledes med benz og diesel
            Console.WriteLine("benzin, diesel eller el?");
            string FuelType = Console.ReadLine();

            while (true)
            {
                // hvis det ikke er benzin/diesel/el
                if (FuelType.ToLower() != "benzin" && FuelType.ToLower() != "diesel" && FuelType.ToLower() != "el")
                {
                    Console.Write("skriv lige benzin, diesel eller el: ");
                    FuelType = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return CarOwner;
        }

    }

}
    // To-do: lav en kort metode til at tænde og slukke bilen






