namespace GtiEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            var fordCar = new Car("Ford");

            var nissanCar = new Car("Nissan", "GTR", "John Doe", "1995");
            var toyotaCar = new Car("Toyota", "Supra", "John Doe", "1995");

            cars.Add(fordCar);
            cars.Add(nissanCar);

            List<Truck> trucks = new List<Truck>();

            var fordTruck = new Truck("Ford", "F-150", "Jane Doe", "1992");
            var nissanTruck = new Truck("Nissan", "Titan", "John Doe", "1999");
            var toyotaTruck = new Truck("Toyota", "Tundra", "John Doe", "2000");

            trucks.Add(fordTruck);
            trucks.Add(nissanTruck);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Maker}");
                Console.WriteLine($"{car.Model}");
                Console.WriteLine($"{car.Client}");
                Console.WriteLine($"{car.ProduceYear}");
            }

            Console.WriteLine();

            foreach (var truck in trucks)
            {
                Console.WriteLine($"{truck.Maker}");
                Console.WriteLine($"{truck.Model}");
                Console.WriteLine($"{truck.Client}");
                Console.WriteLine($"{truck.ProduceYear}");
            }
        }
    }
}
