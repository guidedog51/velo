using BikeDistributor.Models;
using BikeDistributor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeDistributor
{
    public class Order
    {
        public Order(ICompany company)
        {
            Company = company;
        }

        public ICompany Company { get; set; }

        public IEnumerable<LineItem> LineItems { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal Total { get; set; }

        public string ReceiptText { get; set; }

        public string ReceptHtml { get; set; }

        public void AddLine(LineItem line)
        {
            _lines.Add(line);
        }


    }
}
