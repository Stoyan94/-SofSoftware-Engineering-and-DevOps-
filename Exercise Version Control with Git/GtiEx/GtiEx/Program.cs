namespace GtiEx
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            var fordCar = new Car("Ford");

            var nissanCar = new Car("Nissan", "GTR", "John Doe");

            cars.Add(fordCar);
            cars.Add(nissanCar);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Maker}");
                Console.WriteLine($"{car.Model}");
                Console.WriteLine($"{car.Client}");
            }
        }
    }
}
