using System.Collections.Generic;
using BikeDistributor.Interfaces;
using BikeDistributor.Models;

namespace BikeDistributor.Interfaces
{
    public interface IOrder
    {
        /// <summary>
        /// vendor placing order
        /// </summary>
        ICompany Company { get; set; }

        /// <summary>
        /// a collection of items ordered
        /// </summary>
        IList<LineItem> LineItems { get; set; }

        /// <summary>
        /// html output for the initialized order
        /// </summary>
        string ReceiptHtml { get; }

        /// <summary>
        /// plain text output for the initialized order
        /// </summary>
        string ReceiptText { get; }

        /// <summary>
        /// subtotal without tax
        /// </summary>
        decimal SubTotal { get; set; }

        /// <summary>
        /// tax amount on carried subtotal
        /// </summary>
        decimal Tax { get; set; }

        /// <summary>
        /// subtotal plus tax
        /// </summary>
        decimal Total { get; set; }

        /// <summary>
        /// adds line item to collection and recalculates totals
        /// </summary>
        /// <param name="line"></param>
        void AddLineItem(LineItem line);
    }
}