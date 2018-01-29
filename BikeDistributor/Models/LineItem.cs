using BikeDistributor.Interfaces;

namespace BikeDistributor.Models
{
    public class LineItem : ILineItem
    {
        public LineItem()
        {
        }

        public IBike Bike { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal ItemTotal { get; set; }
    }
}
