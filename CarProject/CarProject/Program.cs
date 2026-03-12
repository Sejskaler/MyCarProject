using Microsoft.VisualBasic.FileIO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace CarProject
{
    internal class Program
    {
        private List<Trip> _trips = new List<Trip>();
        static void Main(string[] args)
        {
            double FuelPrice = 0.0;
            double Price = 0.0;
            double Distance = 0.0;


            Car myCar = new Car("Nissan", "Qashqai", 2021, 'M', 130000, fuelType.Gasoline, 16.3, false);

            List<Trip> trips = new List<Trip>
        
            {
            new Trip(50,  DateTime.Now, DateTime.Now.AddHours(1), myCar),
            new Trip(30,  DateTime.Now, DateTime.Now.AddMinutes(30), myCar),
            new Trip(100, DateTime.Now, DateTime.Now.AddHours(2), myCar)
            };
            
            foreach (var trip in trips)
            {
                myCar.Drive(trip);
            }
            myCar.GetTrips();


        }



        static bool IsPalindrome(int km)
        {
            string kmString = km.ToString();
            char[] kmPalindrome = kmString.ToCharArray();
            Array.Reverse(kmPalindrome);
            string kmStringReversed = new string(kmPalindrome);
            if (kmString == kmStringReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
        