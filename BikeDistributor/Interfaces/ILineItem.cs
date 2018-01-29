using BikeDistributor.Interfaces;

namespace BikeDistributor.Interfaces
{
    /// <summary>
    /// sales line item for a bike order
    /// </summary>
    public interface ILineItem
    {
        IBike Bike { get; set; }
        decimal Discount { get; set; }
        decimal ItemTotal { get; set; }
        int Quantity { get; set; }
    }
}