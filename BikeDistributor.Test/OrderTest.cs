using BikeDistributor.Interfaces;
using BikeDistributor.Models;
using BikeDistributor.Test.Properties;
using BikeDistributor.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class OrderTest
    {
        private readonly static IBike Defy = new Bike { Brand = "Giant", Model = "Defy 1", Price = 1000.00M }; 
        private readonly static IBike Elite = new Bike { Brand = "Specialized", Model = "Venge Elite", Price = 2010.00M }; 
        private readonly static IBike DuraAce = new Bike { Brand = "Specialized", Model = "S-Works Venge Dura-Ace", Price = 5555.55M }; 
        private readonly static IBike Tour = new Bike { Brand = "Gazelle", Model = "Tour Populair", Price = 1000.00M };
        private readonly static ICompanyAddress _address = new CompanyAddress { State = "California", County = "Alameda" }; 
        private readonly static IOrder _order = new Order(new Company(_address, "Anywhere Bike Shop"));                                                                                                                                 //var bike = new Bike { Brand = "Gazelle", Model = "Tour Populair", Price = 1000 };
        private readonly static OrderUtilities _utilities = new OrderUtilities();

        [TestMethod]
        public void OrderTour()
        {
            var lineItem = new LineItem(Tour) { Quantity = 30 };
            _order.AddLineItem(lineItem);

            Assert.AreEqual(_order.Total, 29565M);
            _order.LineItems.Clear();
        }

        [TestMethod]
        public void OrderDuraAce()
        {
            var lineItem = new LineItem(DuraAce) { Quantity = 4 };
            _order.AddLineItem(lineItem);

            Assert.AreEqual(_order.Total, 24333.31M);
            _order.LineItems.Clear();
        }

        [TestMethod]
        public void GetSalesTaxRate()
        {
            var address = new CompanyAddress { State = "California", County = "Alameda" };

            var taxRate = _utilities.GetSalesTaxRate(address);

            Assert.IsNotNull(taxRate);
            Assert.AreEqual(.095M, taxRate);
        }

        [TestMethod]
        public void GetSalesTaxRateCase2()
        {
            var address = new CompanyAddress { State = "Nevada", County = "Washoe" };

            var taxRate = _utilities.GetSalesTaxRate(address);

            Assert.IsNotNull(taxRate);
            Assert.AreEqual(0M, taxRate);
        }

        [TestMethod]
        public void GetVolumeDiscount()
        {
            var lineItem = new LineItem(Defy) { Quantity = 30 };
            var discount = _utilities.GetVolumeDiscount(lineItem);

            Assert.IsNotNull(discount);
            Assert.AreEqual(.9M, discount);
        }

        [TestMethod]
        public void GetVolumeDiscountCase2()
        {
            var lineItem = new LineItem(Defy) { Quantity = 10 };
            var discount = _utilities.GetVolumeDiscount(lineItem);

            Assert.IsNotNull(discount);
            Assert.AreEqual(1.0M, discount);
        }

        [TestMethod]
        public void ReceiptOneTour()
        {
            var lineItem = new LineItem(Tour) { Quantity = 30 };
            _order.AddLineItem(lineItem);
            Assert.AreEqual(Resources.TourTextReceipt, _order.ReceiptText);
            _order.LineItems.Clear();
        }

        [TestMethod]
        public void ReceiptOneDuraAce()
        {
            var lineItem = new LineItem(DuraAce) { Quantity = 4 };
            _order.AddLineItem(lineItem);
            Assert.AreEqual(Resources.DuraAceTextReceipt, _order.ReceiptText);
            _order.LineItems.Clear();
        }

        [TestMethod]
        public void HtmlReceiptOneTour()
        {
            var lineItem = new LineItem(Tour) { Quantity = 30 };
            _order.AddLineItem(lineItem);
            Assert.AreEqual(Resources.TourHtmlReceipt, _order.ReceiptHtml);
            _order.LineItems.Clear();
        }

        [TestMethod]
        public void HtmlReceiptOneDuraAce()
        {
            var lineItem = new LineItem(DuraAce) { Quantity = 4 };
            _order.AddLineItem(lineItem);
            Assert.AreEqual(Resources.DuraAceHtmlReceipt, _order.ReceiptHtml);
            _order.LineItems.Clear();
        }
    }
}


