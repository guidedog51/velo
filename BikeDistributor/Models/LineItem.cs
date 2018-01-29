using BikeDistributor.Interfaces;

namespace BikeDistributor.Models
{
    public class LineItem : ILineItem
    {
        /// <summary>
        /// this class defines a sales order line item
        /// </summary>
        public LineItem()
        {
        }
        /// <summary>
        /// a bike for the purposes of a line item
        /// </summary>
        public IBike Bike { get; set; }

        /// <summary>
        /// quantity ordered
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// a discount factor provided for volume purposes
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// carried total for bike.price * quantity * discount
        /// </summary>
        public decimal ItemTotal { get; set; }
    }
}
