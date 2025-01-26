namespace GitBasics
{
    public class Program
    {
        static void Main(string[] args)
        {
            var allPersons = new List<Person>();

            var newPerson = new Person("Stoyan", 25, "hi");

            allPersons.Add(newPerson);
            allPersons.Add(new Person("Richi"));

            foreach (var peron in allPersons)
            {
                Console.WriteLine(peron.Name);

                if (peron.Age == 0 || peron.Speak is null)
                {
                    continue;
                }

                Console.WriteLine(peron.Age);
                Console.WriteLine(peron.Speak);
            }

            var programmer = new Programmer("Maniac");
            Console.WriteLine(programmer.Name);

            programmer.Code();
            programmer.Test();

        }
    }
}
