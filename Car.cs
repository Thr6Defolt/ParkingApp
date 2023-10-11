using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Car
    {
        /// Gets or sets the color of the car.
        public Color CarColor { get; private set; }
        
        /// Gets the brand of the car.
        public string Brand { get; private set; }
        
        /// Gets the model of the car.
        public string Model { get; private set; }
        
        /// Gets the registration number of the car.
        public string Number { get; private set; }
        
        /// Gets the time the car entered parking lot.
        public DateTime TimeIn { get; private set; }

        /// Gets or sets the time the car left parking lot.
        public DateTime? TimeOut { get; set; }


        /// Initializes new instance Car.
        public Car(string brand, string model, Color color, string number, DateTime timeIn)
        {
            Brand = brand;
            Model = model;
            CarColor = color;
            Number = number;
            TimeIn = timeIn;
        }
        
        /// Initializes new instance of the Car class.Use only brand, model & number.
        public Car(string brand, string model, string number) : this(brand, model, new Color(0, 0, 0, 100), number, DateTime.Now)
        {
        }
    }
}
