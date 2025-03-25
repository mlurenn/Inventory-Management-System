using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    internal class Book : Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Language { get; set; }

        public Book(int pid, string name, int price, int stock, string author, string genre, string format, string language)
            : base(pid, name, price, stock)
        {
            Author = author;
            Genre = genre;
            Format = format;
            Language = language;
        }

        public override string ToString()
        {
            return $"{PID} - {Name} ({Author}, {Genre}, {Format}, {Language}) - {Price} SEK, {Stock} in stock";
        }
    }
}
