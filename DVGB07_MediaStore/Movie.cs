using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    internal class Movie : Product
    {
        public string Genre { get; set; }
        public string Format { get; set; }
        public int Length { get; set; }

        public Movie(int pid, string name, int price, int stock, string genre, string format, int length)
            : base(pid, name, price, stock)
        {
            Format = format;
            Length = length;
        }

        public override string ToString()
        {
            return $"{PID} - {Name} ({Genre}, {Format}) - {Price} SEK, {Stock} in stock, {Length} mins";
        }
    }
}
