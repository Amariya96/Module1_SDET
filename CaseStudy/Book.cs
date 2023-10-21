using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CaseStudy
{
    internal class Book
    {
       
        public Book(string? title, string? author, int isbn, int price, string? availability)
        {
            Title = title;
            Authors = author;
            ISBN = isbn;
            Price = price;
           Availability = availability;
        }

        public string? Title {  get; set; }
        public string? Authors { get; set; }
        public int ISBN { get; set; }
        public double Price { get; set; }
        public string? Availability { get; set; }
        public void DisplayBookDetails()
        {
            Console.WriteLine("Title : {0} \n Authors : {1} \n ISBN : {2} \n Price : {3} \n Availability : {4}", Title, Authors, ISBN, Price, Availability);
        }
    }
}
