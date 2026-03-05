using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarProject
{
    internal class Trip
    {
        private double _distance;
        private DateTime _startTime;
        private DateTime _endTime;
        private Car _car;

        public Trip(double Distance, DateTime StartTime, DateTime EndTime, Car car) 
        
        {
            _distance = Distance;
            _startTime = StartTime;
            _endTime = EndTime;
            _car = car;

        }

        public double Distance { get { return _distance; } }

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
       
            double price = CalculateFuelUsed() * FuelPrice;
            return price;
        }

        //Method GetTripDetails

        public string GetTripDetails()
        {
            return $"Der blev kørt en tur. Turen startede d. kl. {_startTime} og sluttede d. kl. {_endTime}. Der blev kørt {_distance} km.";
        }
    }
}
