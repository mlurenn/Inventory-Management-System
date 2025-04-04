using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DVGB07_MediaStore;

namespace Media_Store
{
    internal static class CSVHandler
    {
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "products.csv");

        public static List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();
            HashSet<int> existingPIDs = new HashSet<int>();
            int maxPID = 0;

            if (!File.Exists(filePath))
            {
                return products;
            }

            string[] lines = File.ReadAllLines(filePath).Skip(1).ToArray();

            foreach (var line in lines)
            {
                string[] productValues = line.Split(',');

                if (productValues.Length < 4) continue;

                if (!int.TryParse(productValues[0], out int pid) || existingPIDs.Contains(pid))
                {
                    pid = ++maxPID;
                }

                maxPID = Math.Max(maxPID, pid);
                existingPIDs.Add(pid);

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
            }

            return products;
        }


        public static void SaveProducts(List<Product> products)
        {
            try
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
                        pid = ++maxPID;
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
            catch (IOException ex)
            {
                Console.WriteLine($"File write error: {ex.Message}");
            }
        }

        internal static int GeneratePID()
        {
            List<Product> products = LoadProducts();
            return products.Count > 0 ? products.Max(p => p.PID) + 1 : 1;
        }

    }
}
