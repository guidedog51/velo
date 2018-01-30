using BikeDistributor.Interfaces;

namespace BikeDistributor.Interfaces
{
    /// <summary>
    /// sales line item for a bike order
    /// </summary>
    public interface ILineItem
    {
        /// <summary>
        /// a bike for the purposes of a line item
        /// </summary>
        IBike Bike { get; set; }

        /// <summary>
        /// quantity ordered
        /// </summary>
        decimal Discount { get; set; }

        /// <summary>
        /// a discount factor provided for volume purposes
        /// </summary>
        decimal ItemTotal { get; set; }

        /// <summary>
        /// carried total for bike.price * quantity * discount
        /// </summary>
        int Quantity { get; set; }
    }
}