using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2.BL
{
    class Product
    {

        public List<Product> products = new List<Product>();

        public string Name;
        public string Category;
        public double Price;
        public int Quantity;
        public int MinQuantity;

        public Product()
        {
        }

        public Product(string name, string category, double price, int quantity, int minQuantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            MinQuantity = minQuantity;
        }

        public Product(Product product)
        {
            Name = product.Name;
            Category = product.Category;
            Price = product.Price;
            Quantity = product.Quantity;
            MinQuantity = product.MinQuantity;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Category: " + Category + ", Price: " + Price + ", Quantity: " + Quantity + ", Min Quantity: " + MinQuantity;
        }

        public void AddProduct()
        {
            Console.WriteLine("Enter Product Details:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Category (Groceries/Fresh Fruit): ");
            string category = Console.ReadLine();
            Console.Write("Price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minimum Quantity: ");
            int minQuantity = Convert.ToInt32(Console.ReadLine());
            products.Add(new Product(name, category, price, quantity, minQuantity));
        }

        public void ViewAllProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.ReadKey();
        }

        public void FindProductWithHighestUnitPrice()
        {
            double highestPrice = 0;
            Product highestPriceProduct = null;

            foreach (Product product in products)
            {
                if (product.Price > highestPrice)
                {
                    highestPrice = product.Price;
                    highestPriceProduct = product;
                }
            }
            Console.WriteLine("Product with highest unit price is: " + highestPriceProduct);
            Console.ReadKey();
        }
        public void ViewSalesTaxOfAllProducts()
        {
            foreach (Product product in products)
            {
                double tax = 0;

                if (product.Category == "Groceries")
                {
                    tax = 0.1 * product.Price;
                }
                else if (product.Category == "Fresh Fruit")
                {
                    tax = 0.05 * product.Price;
                }
                else
                {
                    tax = 0.15 * product.Price;
                }
                Console.WriteLine("Product: " + product.Name + ", Category: " + product.Category + ", Tax: " + tax);
                Console.ReadKey();
            }
        }

        public void ProductsToBeOrdered()
        {
            foreach (Product product in products)
            {
                if (product.Quantity < product.MinQuantity)
                {
                    Console.WriteLine("Product: " + product.Name + ", Category: " + product.Category + ", Quantity: " + product.Quantity + ", Minimum Quantity: " + product.MinQuantity);
                }
            }
            Console.ReadKey();
        }
    }

    
}
