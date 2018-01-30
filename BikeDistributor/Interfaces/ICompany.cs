namespace BikeDistributor.Interfaces
{
    public interface ICompany
    {
        /// <summary>
        /// name of the company
        /// </summary>
        ICompanyAddress Address { get; set; }

        /// <summary>
        /// the company address 
        /// </summary>
        string Name { get; set; }
    }
}