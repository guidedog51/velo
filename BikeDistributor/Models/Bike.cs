using BikeDistributor.Interfaces;

namespace BikeDistributor.Models
{
    public class Bike : IBike
    {
    
        public Bike()
        {
        }

        public string Brand { get;  set; }
        public string Model { get;  set; }
        public int Price { get; set; }
    }
}
