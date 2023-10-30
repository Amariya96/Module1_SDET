using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //internal class Product
    //{
    /*public string? proName;
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
        }*/
    internal class Product<T>
    {
        private int ProductId;
        private T Name;
        private double Price;
        private int Quantity;

        public Product(int productId, T name, double price, int quantity)
        {
            ProductId1 = productId;
            Name1 = name;
            Price1 = price;
            Quantity1 = quantity;
        }

        public int ProductId1 { get => ProductId; set => ProductId = value; }
        public T Name1 { get => Name; set => Name = value; }
        public double Price1 { get => Price; set => Price = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }

        public static List<Product<T>> list = new();

        public static void AddProduct(int productid, ref T name, double price, int quantity)
        {
            Product<T> product = new(productid, name, price, quantity);
            list.Add(product);
            Console.WriteLine("Product Added {0}", product.Name);
        }
        public static void UpdateProduct(int productid, T name)
        {
            foreach (var i in list)
            {
                if (i.ProductId == productid)
                {
                    i.Name = name;
                }
            }
            Console.WriteLine("Product Name Updated to {0}", name);
        }
        public static void DeleteProduct(int productid)
        {
            foreach (var i in list)
            {
                if (i.ProductId == productid)
                {
                    list.Remove(i);
                }
                Console.WriteLine("Product Deleted");
            }
        }
        public static void SearchProduct(int id)
        {
            foreach (var i in list)
            {
                if (i.ProductId == id)
                {
                    Console.WriteLine("Product Found\nId:{0},\tName:{1},\tPrice:{2},\tQuantity:{3}", i.ProductId, i.Name, i.Price, i.Quantity);
                }

            }
        }
    }
}





        
    

