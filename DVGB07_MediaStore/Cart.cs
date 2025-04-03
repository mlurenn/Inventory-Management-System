using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Store;

namespace DVGB07_MediaStore
{
    internal class Cart
    {
        public List<Product> Items { get; private set; }

        public Cart()
        {
            Items = new List<Product>();
        }

        public void RemoveFromCart(int PID)
        {
            Product product = Items.FirstOrDefault(p => p.PID == PID);
            if (product != null)
                Items.Remove(product);
        }
        public void AddToCart(Product product) { Items.Add(product); }
        public void EmptyCart() { Items.Clear(); }
        public int GetTotalPrice() {  return Items.Sum(p => p.Price); }
        public List<Product> GetCart() {  return Items; }
    }
}
