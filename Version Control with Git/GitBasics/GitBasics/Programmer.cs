namespace GitBasics
{
    public class Programmer : Person
    {
        public Programmer(string name) 
            : base(name)
        {
            
        }
        public Programmer(string name, int age, string speak) 
            : base(name, age, speak)
        {
        }

        public void Code()
        {
            Console.WriteLine("Coding...");
        }

        public void Test()
        {
            Console.WriteLine("Testing...");
        }
    }
}
