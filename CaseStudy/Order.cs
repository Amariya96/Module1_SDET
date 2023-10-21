using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        BookType[] books = new BookType[10];
        public string? OrderDate { get; set; }
        public double Cost { get; set; }
        
    }
}
