using CarProject;
using Microsoft.VisualBasic.FileIO;

namespace MyCarProjectTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]

        public void GetTripsByDate_ReturnsMatchingTrips()
        { 
    // Arrange 

    Car car = new Car("Toyota", "Corolla", 2020, 'M', 100000, fuelType.Gasoline, 22.5, false);

        car.TurnOnEngine(); 

    DateTime today = new DateTime(2024, 6, 1, 10, 0, 0);

            Trip trip1 = new Trip(50, DateTime.Now, DateTime.Now.AddHours(1), car);
            Trip trip2 = new Trip(30, DateTime.Now, DateTime.Now.AddMinutes(30), car);
            Trip trip3 = new Trip(100, DateTime.Now, DateTime.Now.AddHours(2), car);

        car.Drive(trip1); car.Drive(trip2); car.Drive(trip3); 

 

         // Act 

         List<Trip> result = car.GetTripsByDate(today.Date);



        // Assert 

        Assert.AreEqual(3, result.Count); 

        }
    }
}
