namespace BikeDistributor.Interfaces
{
    public interface ICompany
    {
        ICompanyAddress Address { get; set; }
        string Name { get; set; }
    }
}