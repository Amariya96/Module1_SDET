using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DigitalProducts: ElectronicProducts
    {
        public DigitalProducts(string? fileFormat, int warrantyPeriod, string? proName, double price, int quantity):base(warrantyPeriod,proName,price,quantity)
        {
            FileFormat = fileFormat;

        }
        public string? FileFormat { get; set;}
        public void DisplayDigitalProducts()
        {
            Console.WriteLine("File Format: {0}", FileFormat);
        }
    }
}
