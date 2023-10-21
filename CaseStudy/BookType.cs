using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class BookType : Book
    {
       

        public BookType(string? title, string? author, int isbn, int price, string? availability, string? genre):base(title, author, isbn, price, availability)

        {
            Genre = genre;
        }

        

        public string? Genre { get; set; }
        public void DisplayBookTypeDetails()
        {
            Console.WriteLine("Title: {0} \n Author : {1} \n ISBN : {2} \n Price : {3} \n Availability: {4} \n Genre : {5} ");
        }
    }
}
