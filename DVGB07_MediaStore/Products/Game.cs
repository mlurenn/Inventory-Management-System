using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Store
{
    internal class Game : Product
    {
        public string Genre { get; set; }
        public string Platform { get; set; }

        public Game(int pid, string name, int price, int stock, string genre, string platform)
            : base(pid, name, price, stock) 
        {
            Platform = platform;
        }

        public override string ToString()
        {
            return $"{PID} - {Name} ({Genre}, {Platform}) - {Price} SEK, {Stock} in stock";
        }
    }
}
