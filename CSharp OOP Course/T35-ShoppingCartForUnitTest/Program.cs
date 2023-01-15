using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace T35
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Product> Products { get; set; }

        public string ToString()
        {
            return $"-Product: {Name} {Price} euro";
        }

        public Product()
        {
            Products = new List<Product>();
        }

        public static int Counting(List<Product> products)
        {
            return products.Count;
        }

    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Product product = new Product();
            Product coffee = new Product() { Name = "Coffee", Price = 6.50 };
            Product banana = new Product() { Name = "Banana", Price = 3.20 };
            Product butter = new Product() { Name = "Butter", Price = 3.50 };
            Product cheese = new Product() { Name = "Cheese", Price = 4.10 };

            product.Products.Add(coffee);
            product.Products.Add(banana);
            product.Products.Add(cheese);
            product.Products.Add(butter);

            foreach (Product item in product.Products)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(Product.Counting(product.Products));
           
        }
        
    }
}
