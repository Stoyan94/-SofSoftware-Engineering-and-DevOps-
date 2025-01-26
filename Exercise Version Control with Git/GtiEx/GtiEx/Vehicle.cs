using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtiEx
{
    public class Vehicle
    {
        public Vehicle()
        {
            
        }
        public Vehicle(string maker)
        {
            Maker = maker;
        }
        
        public Vehicle(string maker, string model, string client) : this(maker)
        {
            Model = model;
            Client = client;
        }

        public string Maker { get; set; }
        public string Model { get; set; }
        public string Client { get; set; }
    }
}
