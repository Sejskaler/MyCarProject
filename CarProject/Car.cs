using CarProject;
using System;
using System.Runtime.CompilerServices;

public class Car()
{
    private string _brand;
    private string _model;
    private int _year;
    private char _gear;
    private double _odometer;
    private double _kmPrLiter;
    private bool _engineActive;
    private List<Trip> _trips = [];
    private List<Trip> _tripsByDate = [];

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
       
       
    }


    //Method TurnOnEngine

    public void TurnOnEngine()
        {
        if (_engineActive == false)
            _engineActive = true;

        else
            _engineActive = false;
         }

    // Method - Drive
    public Trip Drive(Trip trip)
    {
        _trips.Add(trip);
        _odometer += trip.Distance;
        return trip;
    }

    // Method GetTrips

    public List<Trip> GetTrips()
    {
        {
            for (int i = 0; i < _trips.Count; i++)
            {
                Console.WriteLine($"trip {i + 1} = {_trips[i].Distance}");
            }
            return _trips;
        }
    }






    // Method - GetTripsByDate

    public List<Trip> GetTripsByDate(DateTime date)

    {
        foreach (Trip trip in _trips) 
        {
            if (trip.StartTime.Date == date.Date)
            {
                _tripsByDate.Add(trip);
                Console.WriteLine($"{trip} tilføjet");
            }

            else
            {
                Console.WriteLine($"{trip} ikke tilføjet");
            }
        }
        return (_tripsByDate);
    }
}







