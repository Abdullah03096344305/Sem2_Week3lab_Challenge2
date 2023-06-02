using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenge2.BL;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product store = new Product();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Find Product with the Highest Unit Price");
                Console.WriteLine("4. View Sales Tax of All Products");
                Console.WriteLine("5. Products to be Ordered (less than the threshold)");
                Console.WriteLine("6. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please enter a valid option");
                    continue;
                }

                if (choice == 1)
                {
                    Console.Clear();
                    store.AddProduct();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    store.ViewAllProducts();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    store.FindProductWithHighestUnitPrice();
                }
                else if (choice == 4)
                {
                    Console.Clear();
                    store.ViewSalesTaxOfAllProducts();
                }
                else if (choice == 5)
                {
                    Console.Clear();
                    store.ProductsToBeOrdered();
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    exit = true;
                    Console.WriteLine("Allah dy Hawale!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice, please enter a valid option");
                }
            }
        }
    }
}
