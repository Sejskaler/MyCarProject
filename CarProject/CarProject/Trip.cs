using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarProject
{
    internal class Trip
    {
        private double _distance;
        private DateTime _tripDate;
        private DateTime _startTime;
        private DateTime _endTime;
        private Car _car;

        public Trip(double Distance,DateTime TripDate, DateTime StartTime, DateTime EndTime, Car car) 
        
        {
            _distance = Distance;
            _tripDate = TripDate;
            _startTime = StartTime;
            _endTime = EndTime;
            _car = car;

        }

        public double Distance { get { return _distance; } }

        public DateTime TripDate { get { return _tripDate; } }

        public DateTime StartTime { get { return _startTime; } }

        public DateTime EndTime { get { return _endTime; } }

        // Method - CalculateDuration

        public TimeSpan CalculateDuration()
        {  return _endTime - _startTime; }

        // Method CalculateFuelUsed

        public double CalculateFuelUsed()
        {
            return _distance / _car.KmPrLiter;
        }

        // Method - CalculateTripPrice
        public double CalculateTripPrice(string FuelType, double KmPrLiter, double FuelPrice)
        {
            Console.WriteLine("Vi kan ikke beregne en køretur uden distance");
            double Distance;
        
            while (true)
            {
                Console.Write("Distance: ");
                string distanceInput = Console.ReadLine();

                if (double.TryParse(distanceInput, out _distance))
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


            double price = CalculateFuelUsed() * FuelPrice;
            return price;
        }

        //Method GetTripDetails

        public string GetTripDetails()
        {
            return $"Der blev kørt en tur d. {_tripDate}, turen startede kl. {_startTime} og sluttede kl. {_endTime}. Der blev kørt {_distance} km.";
        }
    }
}
