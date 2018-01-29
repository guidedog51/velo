using BikeDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor.Models
{
    public class Company : ICompany
    {
        public string Name { get; set; }
        public ICompanyAddress Address { get; set; }
    }

    public class CompanyAddress : ICompanyAddress
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
    }
}
