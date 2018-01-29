using BikeDistributor.Interfaces;
using BikeDistributor.Models;
using BikeDistributor.Properties;
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
        /// Helper class for various order calculations and output
        /// </summary>
        public OrderUtilities()
        {
            var caliRates = new Dictionary<string, decimal>() { { "Alameda", .095M }, { "San Francisco", .085M } };
            var nevadaRates = new Dictionary<string, decimal>() { { "Washoe", 0M }, { "Carson City", 0M } };
            _taxTable = new Dictionary<string, Dictionary<string, decimal>>() { { "California", caliRates }, { "Nevada", nevadaRates } };
        }

        /// <summary>
        /// calculates discount rate based on price point and quantity
        /// </summary>
        /// <param name="lineItem"></param>
        /// <returns></returns>
        public decimal GetVolumeDiscount(ILineItem lineItem)
        {
            var discount = 1.0M;

            if (Enumerable.Range(0, 1001).Contains((int)lineItem.Bike.Price) && lineItem.Quantity >= 20)
                discount = .9M;

            if (Enumerable.Range(1001, 4001).Contains((int)lineItem.Bike.Price) && lineItem.Quantity >= 10)
                discount = .8M;

            if (Enumerable.Range(5001, 10001).Contains((int)lineItem.Bike.Price) && lineItem.Quantity >= 5)
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
            var rate = _taxTable.Where(s => s.Key == companyAddress.State).FirstOrDefault().Value
                .Where(c => c.Key == companyAddress.County).FirstOrDefault().Value;

            return rate;
        }

        /// <summary>
        /// generates plain text string for an order receipt
        /// </summary>
        /// <param name="currentOrder"></param>
        /// <returns></returns>
        public string GetReceiptText(Order currentOrder)
        {
            var lineItems = new StringBuilder();
            foreach (var line in currentOrder.LineItems)
                lineItems.AppendLine(string.Format(Resources.LineItemText, line.Quantity, line.Bike.Brand, line.Bike.Model, line.ItemTotal));

            var textReceipt = string.Format(Resources.ReceiptText, currentOrder.Company.Name, lineItems, currentOrder.SubTotal, currentOrder.Tax, currentOrder.Total);
            return textReceipt;
        }

        /// <summary>
        /// generates html markup for an order receipt
        /// </summary>
        /// <param name="currentOrder"></param>
        /// <returns></returns>
        public string GetReceiptHtml(Order currentOrder)
        {
            var lineItems = new StringBuilder();
            foreach (var line in currentOrder.LineItems)
                lineItems.AppendLine(string.Format(Resources.LineItemHtml, line.Quantity, line.Bike.Brand, line.Bike.Model, line.ItemTotal));

            var htmlReceipt = string.Format(Resources.ReceiptHtml, currentOrder.Company.Name, lineItems, currentOrder.SubTotal, currentOrder.Tax, currentOrder.Total);
            return htmlReceipt;
        }

    }
}
