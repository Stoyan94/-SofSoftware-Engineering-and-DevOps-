namespace GitBasics
{
    public class Person
    {
        public Person()
        {
            
        }

        public Person(string speak)
        {
            Speak = speak;
        }

        public Person(string name, int age, string speak) : this(speak)
        {
            Name = name;
            Age = age;            
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Speak { get; set; }
    }
}

