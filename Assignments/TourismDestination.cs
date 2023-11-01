using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments

{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name {  get; set; }
        public string? Country {  get; set; }
        public int Rating { get; set; }
        public static void DestinationDetails()
        {
        List<TourismDestination> destinations = new List<TourismDestination>();
            destinations.Add(new TourismDestination("Blackpool","Uk",4));
            destinations.Add(new TourismDestination("Thrissur", "India", 3));
            destinations.Add(new TourismDestination("Seoul", "South Korea", 2));
            destinations.Add(new TourismDestination("Paris", "France",1));
            destinations.Add(new TourismDestination("Maldives","Indonesia",5));
            var result = destinations.OrderByDescending(d => d.Rating);
            foreach(var values in result)
            {
                Console.WriteLine(values.Name + " " +values.Country + " " +values.Rating);
            }
        }
    }
}
