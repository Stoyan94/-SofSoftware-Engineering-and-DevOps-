namespace GitBasics
{
    public class Person
    {
        public Person()
        {
            
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int age, string speak) : this(name)
        {
            Age = age;
            Speak = speak;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Speak { get; set; }
    }
}

