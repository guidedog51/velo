using System.Collections.Generic;
using BikeDistributor.Interfaces;
using BikeDistributor.Models;

namespace BikeDistributor.Interfaces
{
    public interface IOrder
    {
        ICompany Company { get; set; }
        IList<LineItem> LineItems { get; set; }
        string ReceiptHtml { get; }
        string ReceiptText { get; }
        decimal SubTotal { get; set; }
        decimal Tax { get; set; }
        decimal Total { get; set; }

        void AddLine(LineItem line);
    }
}