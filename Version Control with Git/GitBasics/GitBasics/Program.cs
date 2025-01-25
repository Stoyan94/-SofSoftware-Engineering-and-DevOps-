namespace GitBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newItem = new List<string>();

            newItem.Add("Name: Person");
            newItem.Add("Age: Person");
            newItem.Add("Speak: Person");

            foreach (var item in newItem)
            {
                Console.WriteLine(item);
            }

        }
    }
}
