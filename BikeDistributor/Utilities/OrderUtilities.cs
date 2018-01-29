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
            var rate = _taxTable.Where(c => c.Key == companyAddress.State).FirstOrDefault().Value
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
            var totalAmount = 0M;
            var result = new StringBuilder(string.Format("Order Receipt for {0}{1}", currentOrder.Company.Name, Environment.NewLine));
            foreach (var line in currentOrder.LineItems)
            {
                var thisAmount = 0M;
                //switch (line.Bike.Price)
                //{
                //case Bike.OneThousand:
                //    if (line.Quantity >= 20)
                //        thisAmount += line.Quantity * line.Bike.Price * .9d;
                //    else
                //        thisAmount += line.Quantity * line.Bike.Price;
                //    break;
                //case Bike.TwoThousand:
                //    if (line.Quantity >= 10)
                //        thisAmount += line.Quantity * line.Bike.Price * .8d;
                //    else
                //        thisAmount += line.Quantity * line.Bike.Price;
                //    break;
                //case Bike.FiveThousand:
                //    if (line.Quantity >= 5)
                //        thisAmount += line.Quantity * line.Bike.Price * .8d;
                //    else
                //        thisAmount += line.Quantity * line.Bike.Price;
                //    break;
                //}
                result.AppendLine(string.Format("\t{0} x {1} {2} = {3}", line.Quantity, line.Bike.Brand, line.Bike.Model, thisAmount.ToString("C")));
                totalAmount += thisAmount;
            }
            result.AppendLine(string.Format("Sub-Total: {0}", totalAmount.ToString("C")));
            var tax = totalAmount * GetSalesTaxRate(currentOrder.Company.Address);
            result.AppendLine(string.Format("Tax: {0}", tax.ToString("C")));
            result.Append(string.Format("Total: {0}", (totalAmount + tax).ToString("C")));
            return result.ToString();
        }

        /// <summary>
        /// generates html markup for an order receipt
        /// </summary>
        /// <param name="currentOrder"></param>
        /// <returns></returns>
        public string GetReceiptHtml(Order currentOrder)
        {
            var totalAmount = 0M;
            var result = new StringBuilder(string.Format("<html><body><h1>Order Receipt for {0}</h1>", currentOrder.Company.Name));
            if (currentOrder.LineItems.Any())
            {
                result.Append("<ul>");
                foreach (var line in currentOrder.LineItems)
                {
                    var thisAmount = 0M;
                    //switch (line.Bike.Price)
                    //{
                    //    case Bike.OneThousand:
                    //        if (line.Quantity >= 20)
                    //            thisAmount += line.Quantity*line.Bike.Price*.9d;
                    //        else
                    //            thisAmount += line.Quantity*line.Bike.Price;
                    //        break;
                    //    case Bike.TwoThousand:
                    //        if (line.Quantity >= 10)
                    //            thisAmount += line.Quantity*line.Bike.Price*.8d;
                    //        else
                    //            thisAmount += line.Quantity*line.Bike.Price;
                    //        break;
                    //    case Bike.FiveThousand:
                    //        if (line.Quantity >= 5)
                    //            thisAmount += line.Quantity*line.Bike.Price*.8d;
                    //        else
                    //            thisAmount += line.Quantity*line.Bike.Price;
                    //        break;
                    //}
                    result.Append(string.Format("<li>{0} x {1} {2} = {3}</li>", line.Quantity, line.Bike.Brand, line.Bike.Model, thisAmount.ToString("C")));
                    totalAmount += thisAmount;
                }
                result.Append("</ul>");
            }
            result.Append(string.Format("<h3>Sub-Total: {0}</h3>", totalAmount.ToString("C")));
            var tax = totalAmount * GetSalesTaxRate(currentOrder.Company.Address);
            result.Append(string.Format("<h3>Tax: {0}</h3>", tax.ToString("C")));
            result.Append(string.Format("<h2>Total: {0}</h2>", (totalAmount + tax).ToString("C")));
            result.Append("</body></html>");
            return result.ToString();
        }

    }
}
