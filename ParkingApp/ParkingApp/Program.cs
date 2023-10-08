namespace ParkingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();
            int totalSpaces = 50;

            Car car1 = new Car("Nissan", "Quashcai", new Car.Color(0, 0, 0, 100), "BC3458AA", DateTime.Now.AddHours(-2));
            Car car2 = new Car("Touata", "Supra", new Car.Color(255, 0, 0, 100), "ВН1991СВ", DateTime.Now.AddHours(-1));

            parking.AddCar(car1, totalSpaces);
            parking.AddCar(car2, totalSpaces);

            parking.DisplayCars();

            parking.RemoveCar(car1);

            parking.DisplayCars();
            
            string stateMessage = parking.GetStateMessage(totalSpaces);
            Console.WriteLine(stateMessage);

            string availableSpacesMessage = parking.AvailableSpacesInParking(totalSpaces);
            Console.WriteLine(availableSpacesMessage);

            parking.InfoParking();
        }
    }
}
