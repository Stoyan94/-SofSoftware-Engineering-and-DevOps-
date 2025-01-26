namespace GtiEx
{
    public class Car
    {
        public Car()
        {
            
        }

        public Car(string maker) : base()
        {
            Maker = maker;
        }

        public Car(string maker ,string model, string client) : this (maker)
        {
            Model = model;
            Client = client;
        }

        public string Maker { get; set; }

        public string Model { get; set; }

        public string Client { get; set; }
    }
}
