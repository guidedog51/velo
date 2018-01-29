using BikeDistributor.Models;
using BikeDistributor.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class OrderTest
    {
        private readonly static Bike Defy = new Bike { Brand = "Giant", Model = "Defy 1", Price = 1000 };   // ("Giant", "Defy 1", 1000);
        private readonly static Bike Elite = new Bike { Brand = "Specialized", Model = "Venge Elite", Price = 2010 };   //   //("Specialized", "Venge Elite", 2010);
        private readonly static Bike DuraAce = new Bike { Brand = "Specialized", Model = "S-Works Venge Dura-Ace", Price = 5555 };   //("Specialized", "S-Works Venge Dura-Ace", 5555);

        [TestMethod]
        public void ReceiptOneDefy()
        {
            var order = new Order("Anywhere Bike Shop");
            //order.AddLine(new Line(Defy, 1));
            Assert.AreEqual(ResultStatementOneDefy, order.Receipt());
        }


        [TestMethod]
        public void GetSalesTaxRate()
        {
            var util = new OrderUtilities();
            var address = new CompanyAddress { State = "California", County = "Alameda" };

            var taxRate = util.GetSalesTaxRate(address);

            Assert.IsNotNull(taxRate);
            Assert.AreEqual(9.5M, taxRate);
        }

        [TestMethod]
        public void GetVolumeDiscount()
        {
            var util = new OrderUtilities();
            //var bike = new Bike { Brand = "Gazelle", Model = "Tour Populair", Price = 1000 };

            var lineItem = new LineItem { Bike = Defy, Quantity = 30 };
            var discount = util.GetDiscount(lineItem);

            Assert.IsNotNull(discount);
            Assert.AreEqual(.9M, discount);
        }



        private const string ResultStatementOneDefy = @"Order Receipt for Anywhere Bike Shop
	1 x Giant Defy 1 = $1,000.00
Sub-Total: $1,000.00
Tax: $72.50
Total: $1,072.50";

        [TestMethod]
        public void ReceiptOneElite()
        {
            var order = new Order("Anywhere Bike Shop");
            //order.AddLine(new Line(Elite, 1));
            Assert.AreEqual(ResultStatementOneElite, order.Receipt());
        }

        private const string ResultStatementOneElite = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized Venge Elite = $2,000.00
Sub-Total: $2,000.00
Tax: $145.00
Total: $2,145.00";

        [TestMethod]
        public void ReceiptOneDuraAce()
        {
            var order = new Order("Anywhere Bike Shop");
            //order.AddLine(new Line(DuraAce, 1));
            Assert.AreEqual(ResultStatementOneDuraAce, order.Receipt());
        }

        private const string ResultStatementOneDuraAce = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized S-Works Venge Dura-Ace = $5,000.00
Sub-Total: $5,000.00
Tax: $362.50
Total: $5,362.50";

        [TestMethod]
        public void HtmlReceiptOneDefy()
        {
            var order = new Order("Anywhere Bike Shop");
            //order.AddLine(new Line(Defy, 1));
            Assert.AreEqual(HtmlResultStatementOneDefy, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneDefy = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Giant Defy 1 = $1,000.00</li></ul><h3>Sub-Total: $1,000.00</h3><h3>Tax: $72.50</h3><h2>Total: $1,072.50</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneElite()
        {
            var order = new Order("Anywhere Bike Shop");
            //order.AddLine(new Line(Elite, 1));
            Assert.AreEqual(HtmlResultStatementOneElite, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneElite = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized Venge Elite = $2,000.00</li></ul><h3>Sub-Total: $2,000.00</h3><h3>Tax: $145.00</h3><h2>Total: $2,145.00</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneDuraAce()
        {
            var order = new Order("Anywhere Bike Shop");
           // order.AddLine(new Line(DuraAce, 1));
            Assert.AreEqual(HtmlResultStatementOneDuraAce, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneDuraAce = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized S-Works Venge Dura-Ace = $5,000.00</li></ul><h3>Sub-Total: $5,000.00</h3><h3>Tax: $362.50</h3><h2>Total: $5,362.50</h2></body></html>";    
    }
}


