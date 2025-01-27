using System.Diagnostics.Metrics;

namespace GtiEx
{
    public class Car : Vehicle
    {
        public Car(string maker) : base(maker)
        {

        }

        public Car(string maker, string model, string client, string produceYear) 
            : base(maker, model, client, produceYear) {}
    }
}
