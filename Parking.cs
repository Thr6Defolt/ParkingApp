using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    /// Manages a collection of cars.
    class Parking : IDisposable
    {
        private List<Car> _cars = new List<Car>();
        private int totalParkingSpaces = 50;

        /// Add a car to parking.
        public string AddCar(Car car)
        {
            int occupiedSpaces = _cars.Count;
            int availableSpaces = totalParkingSpaces - occupiedSpaces;
            if (availableSpaces >= 0)
            {
                _cars.Add(car);
                Console.WriteLine($"Car add {car.Brand}, {car.Model}");
                return $"Car add.";
            }
            else
            {
                Console.WriteLine($"Car do not add because parking full.");
                return $"Car do not add because parking full.";
            }
        }
        /// Add a car to parking.Use onlu Brand, model & number
        public string AddCar(string brand, string model, string number)
        {
            Car car = new Car(brand, model, new Color(255, 255, 255, 0), number, DateTime.Now);
            return AddCar(car);
        }

        /// Remove a car to parking.
        public string RemoveCar(Car car)
        {
            if (_cars.Contains(car))
            {
                _cars.Remove(car);
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

        /// Remove a car to parking.Use onlu number
        public string RemoveCar(string number)
        {
            Console.WriteLine($"Cars with {number} :");
            foreach (var car in _cars)
            {
                if (car.Number == number)
                {
                    _cars.Remove(car);
                    car.TimeOut = DateTime.Now;
                    Console.WriteLine($"Mark: {car.Brand}, Model: {car.Model},Number: {car.Number}, Time Out: {car.TimeOut} car removed.");
                    return $"Car removed.";
                }
                else
                {
                    Console.WriteLine($"Car with number {number} not found.");
                    return $"Car not found.";
                }
            }
            return $"Parking does have car.";
        }

        /// Displays information about cars in the parking lot.
        public void DisplayCars()
        {
            Console.WriteLine("Car on parking:");
            foreach (var car in _cars)
            {
                Console.WriteLine($"Mark: {car.Brand}, Model: {car.Model}, Color: {car.CarColor}, Number: {car.Number}, Time Arvid: {car.TimeIn}, Time Out: {car.TimeOut}");
            }
        }

        /// Displays information about cars in the parking lot.Use onlu brand
        public void DisplayCars(string brand)
        {
            Console.WriteLine($"Cars with {brand} brand:");
            foreach (var car in _cars)
            {
                if (car.Brand == brand)
                {
                    Console.WriteLine($"Mark: {car.Brand}, Model: {car.Model}, Color: {car.CarColor}, Number: {car.Number}, Time Arvid: {car.TimeIn}, Time Out: {car.TimeOut}");
                }
            }
        }
        /// Information about the parking lot.
        public void InfoParking()
        {
            Console.WriteLine($"Parking `CarSite` we locate in stret.Puskina. We have 50 parking space");
        }

        /// Information about the parking lot.With replacement address
        public void InfoParking(string address)
        {
            Console.WriteLine($"Parking 'CarSite' is located at {address}.");
        }
        /// Gets a message the state of parking spaces.
        public string GetStateMessage()
        {
            int occupiedSpaces = _cars.Count;
            int availableSpaces = totalParkingSpaces - occupiedSpaces;

            return $"Total Parking Spaces: {totalParkingSpaces}, Occupied Spaces: {occupiedSpaces}, Available Spaces: {availableSpaces}";
        }
        /// Gets a message of available parking spaces.
        public string AvailableSpacesInParking()
        {
            int occupiedSpaces = _cars.Count;
            int availableSpaces = totalParkingSpaces - occupiedSpaces;
            return $"Available Spaces: {availableSpaces}";
        }

        /// Delet all cars from parking lot.
        public void Dispose()
        {
            foreach (var car in _cars)
            {
                car.TimeOut = DateTime.Now;
            }
            _cars.Clear();
        }

        /// Initializes new instance of the Parking class.
        public Parking()
        {
        }
        
        /// Initializes new instance of the Parking class with total parking spaces count
        public Parking(int totalSpaces)
        {
            totalParkingSpaces = totalSpaces;
        }

        /// Initializes new instance of the Parking class with list of cars.
        public Parking(List<Car> cars)
        {
            _cars = cars;
        }
    }
}
