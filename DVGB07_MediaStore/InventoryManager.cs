using System;
using System.Collections.Generic;
using System.Linq;

namespace Media_Store
{
    internal class InventoryManager
    {
        private List<Product> products;

        public InventoryManager()
        {
            products = CSVHandler.LoadProducts();
        }

        // Lägg till en ny produkt i lager
        public bool AddProduct(Product product)
        {
            // Kontrollera om produktens PID redan finns i lagret
            if (products.Any(p => p.PID == product.PID))
            {
                Console.WriteLine("Ett produkt-ID med samma nummer finns redan.");
                return false;
            }

            products.Add(product);
            CSVHandler.SaveProducts(products);  // Spara förändringar till fil
            Console.WriteLine($"Produkt {product.Name} lagd till i lager.");
            return true;
        }
    }
}
