using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? country, int rating, double pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }
        public double PricePerNight { get; set; }

        public static void Destinations()
        {
            List<TouristDestination> tds = new List<TouristDestination>();
            tds.Add(new TouristDestination("Blackpool", "Uk", 4, 26000));
            tds.Add(new TouristDestination("Thrissur", "India", 3, 15000));
            tds.Add(new TouristDestination("Seoul", "South Korea", 2, 60000));
            tds.Add(new TouristDestination("Paris", "France", 1, 75000));
            tds.Add(new TouristDestination("Maldives", "Indonesia", 5,20000));
            var result = tds.FindAll(d => d.Rating>3);
            foreach (var values in result)
            {
                Console.WriteLine(values.Name + " " + values.Country + " " + values.Rating);
            }
            var result1 = tds.OrderBy(d => d.PricePerNight);
            foreach (var values in result1)
            {
                Console.WriteLine(values.Name + " " + values.Country + " " + values.Rating);
            }
            var result2 = tds.Where(d => d.Country.Equals ("France"));
            foreach (var values in result2)
            {
                Console.WriteLine(values.Name + " " + values.Country + " " + values.Rating);
            }

        }
    }
}
