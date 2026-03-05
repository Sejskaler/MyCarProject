using CarProject;
using System;

public class Car()
    {
        private string _brand;
        private string _model;
        private int _year;
        private char _gear;
        private double _odometer;
        private double _kmPrLiter;
        private bool _engineActive;
        private List<Trip> _trips =  new List<Trip>();

    // Constructor
    public Car(string Brand, string Model, int Year, char Gear, double Odometer, fuelType FuelType, double KmPrLiter, bool EngineActive) : this()
           
        {
            _brand = Brand;
            _model = Model;
            _year = Year;
            _gear = Gear;
            _odometer = Odometer;
            fuelType = FuelType;
            _kmPrLiter = KmPrLiter;
            _engineActive = EngineActive;
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
        public fuelType fuelType { get; private set; }

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
        public void Drive()
        {
        Trip trip1 = new Trip(200, new DateTime(2026, 3, 5, 21, 15, 0), new DateTime(2026, 3, 5, 23, 30, 0), new Car("Nissan", "Qashqai", 2021, 'M', 130000, fuelType.Gasoline, 16.3, true));

        _odometer += trip1.Distance;
        _trips.Add (trip1);

        }

        // Method GetTrips

         public List<Trip> GetTrips()
          { return _trips; }

 
          
  
     

       

        // Method - ReadCarDetails
       

    }







