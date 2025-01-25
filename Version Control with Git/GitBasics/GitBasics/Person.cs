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

        public Person(string speak, string name, int age) : this(speak)
        {
            Name = name;
            Age = age;            
        }
        public string Name { get; set; }
        public string Speak { get; set; }
        public int Age { get; set; }
    }
}

