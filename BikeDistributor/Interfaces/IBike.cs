namespace BikeDistributor.Interfaces
{
    public interface IBike
    {
        /// <summary>
        /// Brand name for the bike
        /// </summary>
        string Brand { get; set; }

        /// <summary>
        /// model name for the bike
        /// </summary>
        string Model { get; set; }

        /// <summary>
        /// wholesale price for the bike
        /// </summary>
        decimal Price { get; set; }
    }
}