using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct : Product, IOrderable
    {
        public double Weight {  get; set; }
        public string? Dimensions {  get; set; }
        public static List<PhysicalProduct> Products = new List<PhysicalProduct>();

       

        public void PlaceOrder()
        {
            Console.WriteLine("Do you want to continue the order\n1.Yes\n2.No");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (Quantity > 0)
                    Console.WriteLine("Continue to payment");
                else
                    Console.WriteLine("Product not available");
            }
            else
            {
                Console.WriteLine("Reverting");
            }

        }

        public void ProcessPayments()
        {
            Console.WriteLine("Enter the card details for product {0}", Name);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine("Payment successful");
            }
        }
        public void DeliverProducts()
        {
            Console.WriteLine("Product is shipped and shipping cost is {0}", Weight * 10);
        }
    }
}
