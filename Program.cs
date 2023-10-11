namespace ParkingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking();

            Car car1 = new Car("Nissan", "Quashcai", new Color(0, 0, 0, 100), "BC3458AA", DateTime.Now.AddHours(-2));
            Car car2 = new Car("Touata", "Supra", new Color(255, 0, 0, 100), "ВН1991СВ", DateTime.Now.AddHours(-1));

            parking.AddCar(car1);
            parking.AddCar(car2);

            parking.DisplayCars();

            parking.RemoveCar(car1);

            parking.DisplayCars();
            
            string stateMessage = parking.GetStateMessage();
            Console.WriteLine(stateMessage);

            string availableSpacesMessage = parking.AvailableSpacesInParking();
            Console.WriteLine(availableSpacesMessage);

            parking.InfoParking();

            parking.RemoveCar("ВН1991СВ");

            parking.DisplayCars();
        }
    }
}
