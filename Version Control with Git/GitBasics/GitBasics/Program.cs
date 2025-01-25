namespace GitBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var allPersons = new List<Person>();

            var newPerson = new Person("Hi", "Stoyan", 25);

            allPersons.Add(newPerson);
            allPersons.Add(new Person("Hi"));

            foreach (var peron in allPersons)
            {
                Console.WriteLine(peron.Speak);

                if (peron.Age == 0 || peron.Name is null)
                {
                    continue;
                }

                Console.WriteLine(peron.Name);
                Console.WriteLine(peron.Age);
            }

        }
    }
}
