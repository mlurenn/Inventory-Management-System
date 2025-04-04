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
        private Dictionary<int, (Product product, int quantity)> cartItems;

        public Cart()
        {
            cartItems = new Dictionary<int, (Product, int)>();
        }

        public void AddToCart(Product product)
        {
            if (cartItems.ContainsKey(product.PID))
            {
                cartItems[product.PID] = (product, cartItems[product.PID].quantity + 1);
            }
            else
            {
                cartItems[product.PID] = (product, 1);
            }
        }

        public void RemoveFromCart(int pid)
        {
            if (cartItems.ContainsKey(pid))
            {
                if (cartItems[pid].quantity > 1)
                {
                    cartItems[pid] = (cartItems[pid].product, cartItems[pid].quantity - 1);
                }
                else
                {
                    cartItems.Remove(pid);
                }
            }
        }

        public List<Product> GetCart()
        {
            return cartItems.Values.Select(item =>
            {
                var clonedProduct = (Product)item.product.Clone();
                clonedProduct.Stock = item.quantity;
                return clonedProduct;
            }).ToList();
        }

        public void EmptyCart()
        {
            cartItems.Clear();
        }

        public int GetQuantityInCart(int PID)
        {
            if (cartItems.ContainsKey(PID))
                return cartItems[PID].quantity;
            else return 0;
        }

        public int GetTotalPrice()
        {
            int total = 0;
            foreach (var item in cartItems.Values)
            {
                total += item.product.Price * item.quantity;
            }
            return total;
        }
    }

}
