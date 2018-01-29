using BikeDistributor.Interfaces;
using BikeDistributor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor.Utilities
{
    public class OrderUtilities
    {

        private Dictionary<string, Dictionary<string, decimal>> _taxTable;

        /// <summary>
        /// Helper class for various order calculations
        /// </summary>
        public OrderUtilities()
        {
            var caliRates = new Dictionary<string, decimal>() { { "Alameda", 9.5M }, { "San Francisco", 8.5M } };
            var nevadaRates = new Dictionary<string, decimal>() { { "Washoe", 9.5M }, { "Carson City", 8.5M } };
            _taxTable = new Dictionary<string, Dictionary<string, decimal>>() { { "California", caliRates }, { "Nevada", nevadaRates } };
        }

        /// <summary>
        /// calculates discount rate based on price point and quantity
        /// </summary>
        /// <param name="lineItem"></param>
        /// <returns></returns>
        public decimal GetDiscount(ILineItem lineItem)
        {
            var discount = .0M;

            if (Enumerable.Range(0, 1001).Contains(lineItem.Bike.Price) && lineItem.Quantity >= 20)
                discount = .9M;

            if (Enumerable.Range(1001, 4001).Contains(lineItem.Bike.Price) && lineItem.Quantity >= 10)
                discount = .8M;

            if (Enumerable.Range(5001, 10001).Contains(lineItem.Bike.Price) && lineItem.Quantity >= 5)
                discount = .8M;

            return discount;
        }

        /// <summary>
        /// looks up tax rate per state/county in sales tax table
        /// </summary>
        /// <param name="companyAddress"></param>
        /// <returns></returns>
        public decimal GetSalesTaxRate(ICompanyAddress companyAddress)
        {
            var rate = _taxTable.Where(c => c.Key == companyAddress.State).FirstOrDefault().Value
                .Where(c => c.Key == companyAddress.County).FirstOrDefault().Value;

            return rate;
        }
    }
}
