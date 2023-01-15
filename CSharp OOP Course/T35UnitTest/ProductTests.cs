using Microsoft.VisualStudio.TestTools.UnitTesting;
using T35;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T35.Tests
{
    [TestClass()]
    public class ProductTests
    {

        [TestMethod()]
        public void CountingTest1()
        {
            Product product = new Product();

            int actual = Product.Counting(product.Products);

            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountingTest2()
        {
            Product product = new Product();
            Product coffee = new Product() { Name = "Coffee", Price = 6.50 };
            product.Products.Add(coffee);

            int actual = Product.Counting(product.Products);
            
            int expected = 1;
            Assert.AreEqual(expected, actual); 
        }

        [TestMethod()]
        public void CountingTest3()
        {
            Product product = new Product();
            Product coffee = new Product() { Name = "Coffee", Price = 6.50 };
            Product banana = new Product() { Name = "Coffee", Price = 6.50 };
            product.Products.Add(coffee);
            product.Products.Add(banana);

            int actual = Product.Counting(product.Products);

            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CountingTest4()
        {
            Product product = new Product();
            Product coffee = new Product() { Name = "Coffee", Price = 6.50 };
            Product banana = new Product() { Name = "Coffee", Price = 6.50 };
            Product butter = new Product() { Name = "Butter", Price = 3.50 };
            Product cheese = new Product() { Name = "Cheese", Price = 4.10 };
            Product chocolate = new Product() { Name = "Chocolate", Price = 4.10 };

            product.Products.Add(coffee);
            product.Products.Add(banana);
            product.Products.Add(cheese);
            product.Products.Add(butter);
            product.Products.Add(chocolate);

            int actual = Product.Counting(product.Products);

            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}