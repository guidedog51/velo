using BikeDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor.Models
{
    /// <summary>
    /// this class defines a company / vendor 
    /// for purposes of a sales order
    /// </summary>
    public class Company : ICompany
    {
        public Company(ICompanyAddress address, string name)
        {
            Name = name;
            Address = address;
        }
        
        /// <summary>
        /// name of the company
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// the company address 
        /// </summary>
        public ICompanyAddress Address { get; set; }
    }

    /// <summary>
    /// this class defines a vendor address
    /// </summary>
    public class CompanyAddress : ICompanyAddress
    {
        /// <summary>
        /// company city
        /// </summary>
        public string City { get; set; }
        
        /// <summary>
        /// company state
        /// </summary>
        public string State { get; set; }
        
        /// <summary>
        /// company zip
        /// </summary>
        public string Zip { get; set; }
        
        /// <summary>
        /// company county 
        /// </summary>
        public string County { get; set; }
    }
}
