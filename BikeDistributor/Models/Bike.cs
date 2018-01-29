using BikeDistributor.Interfaces;

namespace BikeDistributor.Models
{
    public class Bike : IBike
    {
        /// <summary>
        /// this class defines a bike for the purposes of a
        /// sales order
        /// </summary>
        public Bike()
        {
        }

        /// <summary>
        /// Brand name for the bike
        /// </summary>
        public string Brand { get;  set; }
        
        /// <summary>
        /// model name for the bike
        /// </summary>
        public string Model { get;  set; }
        
        /// <summary>
        /// wholesale price for the bike
        /// </summary>
        public decimal Price { get; set; }
    }
}
