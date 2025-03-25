using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Media_Store
{
    internal static class CSVHandler
    {
        private static string filePath = @"C:\Users\melke\source\repos\DVGB07_MediaStore\DVGB07_MediaStore\products.csv";

        public static List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();
            HashSet<int> existingPIDs = new HashSet<int>(); // Spåra unika PID:er
            int maxPID = 0;

            Console.WriteLine($"Filväg för produkter: {filePath}");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Filen finns inte.");
                return products;
            }

            string[] lines = File.ReadAllLines(filePath).Skip(1).ToArray();
            Console.WriteLine($"Läser in {lines.Length} rader.");

            foreach (var line in lines)
            {
                string[] productValues = line.Split(',');
                if (productValues.Length < 4) continue;

                if (!int.TryParse(productValues[0], out int pid) || existingPIDs.Contains(pid))
                {
                    pid = ++maxPID; // Skapa nytt PID om dubblett hittas
                }

                string name = productValues[1];
                if (!int.TryParse(productValues[2], out int price)) continue;
                if (!int.TryParse(productValues[3], out int stock)) continue;

                if (productValues.Length == 8)
                {
                    string author = productValues[4];
                    string genre = productValues[5];
                    string format = productValues[6];
                    string language = productValues[7];
                    products.Add(new Book(pid, name, price, stock, author, genre, format, language));
                }
                else if (productValues.Length == 6)
                {
                    string genre = productValues[4];
                    string platform = productValues[5];
                    products.Add(new Game(pid, name, price, stock, genre, platform));
                }
                else if (productValues.Length == 7)
                {
                    string genre = productValues[4];
                    string format = productValues[5];
                    if (!int.TryParse(productValues[6], out int length)) continue;
                    products.Add(new Movie(pid, name, price, stock, genre, format, length));
                }

                existingPIDs.Add(pid);
                maxPID = Math.Max(maxPID, pid);
            }

            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            List<string> productRows = new List<string>();
            HashSet<int> usedPIDs = new HashSet<int>();

            productRows.Add("PID,Name,Price,Stock,Author,Genre,Format,Language,Platform,Length");

            int maxPID = products.Count > 0 ? products.Max(p => p.PID) : 0;

            foreach (var product in products)
            {
                int pid = product.PID;

                if (usedPIDs.Contains(pid) || pid == 0)
                {
                    pid = ++maxPID; // Ge nytt PID vid konflikt
                    product.PID = pid;
                }

                usedPIDs.Add(pid);

                if (product is Book book)
                {
                    productRows.Add($"{book.PID},{book.Name},{book.Price},{book.Stock},{book.Author},{book.Genre},{book.Format},{book.Language}");
                }
                else if (product is Game game)
                {
                    productRows.Add($"{game.PID},{game.Name},{game.Price},{game.Stock},{game.Genre},{game.Platform}");
                }
                else if (product is Movie movie)
                {
                    productRows.Add($"{movie.PID},{movie.Name},{movie.Price},{movie.Stock},{movie.Genre},{movie.Format},{movie.Length}");
                }
            }

            File.WriteAllLines(filePath, productRows);
        }
    }
}
