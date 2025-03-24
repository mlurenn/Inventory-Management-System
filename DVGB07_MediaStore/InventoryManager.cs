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

        // Ta bort en produkt från lager
        public bool RemoveProduct(int pid)
        {
            var product = products.FirstOrDefault(p => p.PID == pid);
            if (product == null)
            {
                Console.WriteLine("Produkten finns inte i lagret.");
                return false;
            }

            // Kontrollera om lagerstatus är större än 0
            if (product.Stock > 0)
            {
                Console.WriteLine("Produkten har lagerstatus större än 0, kan inte tas bort utan bekräftelse.");
                return false;
            }

            products.Remove(product);
            CSVHandler.SaveProducts(products);  // Spara förändringar till fil
            Console.WriteLine($"Produkt {product.Name} borttagen från lager.");
            return true;
        }

        // Uppdatera lagret för en produkt (antalet)
        public bool UpdateStock(int pid, int quantity)
        {
            var product = products.FirstOrDefault(p => p.PID == pid);
            if (product == null)
            {
                Console.WriteLine("Produkten finns inte i lagret.");
                return false;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Antalet kan inte vara negativt.");
                return false;
            }

            product.Stock = quantity;
            CSVHandler.SaveProducts(products);  // Spara förändringar till fil
            Console.WriteLine($"Produkt {product.Name} lager uppdaterat. Ny lagerstatus: {product.Stock}");
            return true;
        }

        // Hantera försäljning av produkt
        public bool SellProduct(int pid, int quantity)
        {
            var product = products.FirstOrDefault(p => p.PID == pid);
            if (product == null)
            {
                Console.WriteLine("Produkten finns inte i lagret.");
                return false;
            }

            if (product.Stock < quantity)
            {
                Console.WriteLine("Inte tillräckligt med lager för att genomföra försäljning.");
                return false;
            }

            product.Stock -= quantity;
            CSVHandler.SaveProducts(products);  // Spara förändringar till fil
            Console.WriteLine($"Försäljning genomförd för {quantity} av produkten {product.Name}. Ny lagerstatus: {product.Stock}");
            return true;
        }

        // Lista alla produkter i lagret
        public void ListProducts()
        {
            Console.WriteLine("Produkter i lager:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.PID}: {product.Name} - {product.Price} SEK - Lager: {product.Stock}");
            }
        }
    }
}
