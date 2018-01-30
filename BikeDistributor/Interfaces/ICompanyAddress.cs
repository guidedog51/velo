namespace BikeDistributor.Interfaces
{
    public interface ICompanyAddress
    {
        /// <summary>
        /// company city
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// company state
        /// </summary>
        string County { get; set; }

        /// <summary>
        /// company zip
        /// </summary>
        string State { get; set; }

        /// <summary>
        /// company county 
        /// </summary>
        string Zip { get; set; }
    }
}