namespace BikeDistributor.Interfaces
{
    public interface IBike
    {
        string Brand { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
    }
}