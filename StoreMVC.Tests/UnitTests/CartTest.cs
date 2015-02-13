using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreMVC.Domain.Entities;

namespace StoreMVC.Tests.UnitTests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void Can_Add_New_Lines()
        {
            Product p1 = new Product {Name = "P1"};
            Product p2 = new Product { Name = "P2" };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            CartLine[] results = target.Lines.ToArray();

            Assert.AreEqual(results.Length, 2);
            Assert.AreEqual(results[0].Product, p1);
            Assert.AreEqual(results[1].Product, p2);
        }

        [TestMethod]
        public void Can_Add_Quantity_For_Existing_Lines()
        {
            Product p1 = new Product { Name = "P1" };
            Product p2 = new Product { Name = "P2" };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 10);
            CartLine[] results = target.Lines.OrderBy(c => c.Product.Id).ToArray();

            Assert.AreEqual(results.Length, 2);
            Assert.AreEqual(results[0].Quantity, 11);
            Assert.AreEqual(results[1].Quantity, 1);
        }

        [TestMethod]
        public void Can_Remote_Line()
        {
            Product p1 = new Product { Name = "P1" };
            Product p2 = new Product { Name = "P2" };
            Product p3 = new Product { Name = "P3" };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 1);

            target.RemoveLive(p2);

            Assert.AreEqual(target.Lines.Where(c => c.Product.Equals(p2)).Count(), 0);
            Assert.AreEqual(target.Lines, 0);
        }

        [TestMethod]
        public void Calculate_Cart_Module()
        {
            Product p1 = new Product { Name = "P1", Price = 100M};
            Product p2 = new Product { Name = "P2", Price = 50M};

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p2, 3);

            decimal result = target.ComputeTotalValue();

            Assert.AreEqual(result, 450M);
        }

        [TestMethod]
        public void Can_Clear_Contens()
        {
            Product p1 = new Product { Name = "P1", Price = 100M };
            Product p2 = new Product { Name = "P2", Price = 50M };

            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);

            target.Clear();

            Assert.AreEqual(target.Lines.Any(), false);
        }
    }
}
