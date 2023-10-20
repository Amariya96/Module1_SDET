using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        public string? proName;
        public double price, quantity;
        public string ProName { get => ProName; set => proName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public Product(string proName, double price, double quantity) {
            this.ProName = proName;
            this.Price = price;
            this.Quantity = quantity;
        }
     public void SetPrice(double newPrice) {
            price = newPrice;
        }
        public double ProductValue()
        { return Price * Quantity;
        }
        public void DisplayProduct()
            {
                Console.WriteLine("Product Name: " + proName);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Quantity: " + quantity);
            }
                }
    }

