
using System;
using System.Linq;

namespace ECommercePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Product[] products = {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Smartphone", "Electronics"),
                new Product(3, "Shoes", "Footwear"),
                new Product(4, "Backpack", "Accessories"),
                new Product(5, "Watch", "Accessories")
            };

            Console.WriteLine("Search using Linear Search:");
            Product foundProduct = LinearSearch(products, "Smartphone");
            Console.WriteLine(foundProduct != null ? foundProduct.ToString() : "Product not found");

            Console.WriteLine("\nSearch using Binary Search:");
            Product[] sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            foundProduct = BinarySearch(sortedProducts, "Smartphone");
            Console.WriteLine(foundProduct != null ? foundProduct.ToString() : "Product not found");
        }

        
        static Product LinearSearch(Product[] products, string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        
        static Product BinarySearch(Product[] products, string productName)
        {
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int comparison = string.Compare(products[mid].ProductName, productName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                {
                    return products[mid];
                }
                else if (comparison < 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }
}
