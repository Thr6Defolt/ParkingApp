using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    /// Manages a collection of cars.
    class Parking
    {
        private List<Car> cars = new List<Car>();
        /// Add a car to parking.
        public string AddCar(Car car, int totalParkingSpaces)
        {
            int occupiedSpaces = cars.Count;
            int availableSpaces = totalParkingSpaces - occupiedSpaces;
            if (availableSpaces >= 0)
            {
                cars.Add(car);
                Console.WriteLine($"Car add {car.Makr}, {car.Model}");
                return $"Car add.";
            }
            else
            {
                Console.WriteLine($"Car do not add because parking full.");
                return $"Car do not add because parking full.";
            }
        }
        /// Remove a car to parking.
        public string RemoveCar(Car car)
        {
            if (cars.Contains(car))
            {
                cars.Remove(car);
                car.TimeOut = DateTime.Now;
                Console.WriteLine($"Car not removd.");
                return $"Car not removd.";
            }
            else
            {
                Console.WriteLine($"Car not found.");
                return $"Car not found.";
            }
        }
        /// Displays information about cars in the parking lot.
        public void DisplayCars()
        {
            Console.WriteLine("Car on parking:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Mark: {car.Makr}, Model: {car.Model}, Color: {car.CarColor}, Number: {car.Number}, Time Arvid: {car.TimeArvid}, Time Out: {car.TimeOut}");
            }
        }
        /// Information about the parking lot.
        public void InfoParking()
        {
            Console.WriteLine($"Parking `CarSite` we locate in stret.Puskina. We have 50 parking space");
        }
        /// Gets a message the state of parking spaces.
        public string GetStateMessage(int totalParkingSpaces)
        {
            int occupiedSpaces = cars.Count;
            int availableSpaces = totalParkingSpaces - occupiedSpaces;

            return $"Total Parking Spaces: {totalParkingSpaces}, Occupied Spaces: {occupiedSpaces}, Available Spaces: {availableSpaces}";
        }
        /// Gets a message of available parking spaces.
        public string AvailableSpacesInParking(int totalParkingSpaces)
        {
            int occupiedSpaces = cars.Count;
            int availableSpaces = totalParkingSpaces - occupiedSpaces;
            return $"Available Spaces: {availableSpaces}";
        }
    }
}
