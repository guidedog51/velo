namespace BikeDistributor.Interfaces
{
    public interface ICompanyAddress
    {
        string City { get; set; }
        string County { get; set; }
        string State { get; set; }
        string Zip { get; set; }
    }
}