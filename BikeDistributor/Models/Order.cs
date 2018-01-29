using BikeDistributor.Models;
using BikeDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BikeDistributor.Utilities;

namespace BikeDistributor.Models
{
    public class Order : IOrder
    {
        OrderUtilities _utilities = new OrderUtilities();
        /// <summary>
        /// this class defines an order for wholesale bike purchases
        /// </summary>
        /// <param name="company"></param>
        public Order(ICompany company)
        {
            Company = company;
        }

        /// <summary>
        /// vendor placing order
        /// </summary>
        public ICompany Company { get; set; }

        /// <summary>
        /// a collection of items ordered
        /// </summary>
        public IList<LineItem> LineItems { get; set; }

        /// <summary>
        /// subtotal without tax
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// tax amount on carried subtotal
        /// </summary>
        public decimal Tax { get; set; }

        /// <summary>
        /// subtotal plus tax
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// plain text output for the initialized order
        /// </summary>
        public string ReceiptText {
            get
            {
                return _utilities.GetReceiptText(this);
            }
        }

        /// <summary>
        /// html output for the initialized order
        /// </summary>
        public string ReceiptHtml
        {
            get
            {
                return _utilities.GetReceiptText(this);
            }
        }

        public void AddLine(LineItem line)
        {
            LineItems.Add(line);
        }
    }
}
