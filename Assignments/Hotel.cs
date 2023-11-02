using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? hotelname, int availablerm, string? name, string? country, int rating) : base(name, country, rating)
        {
            HotelName = hotelname;
            AvailableRm = availablerm;
        }

        public string? HotelName {  get; set; }
        public int AvailableRm {  get; set; }   
    
        public async Task HotelBooking(int requestedRm)
        {
         if(requestedRm <= AvailableRm) {
                await Task.Delay(1000);
                AvailableRm -= requestedRm;
                Console.WriteLine($"{requestedRm} are booked. Available rooms are:{AvailableRm}");
            }
         else { Console.WriteLine("Sorry, Rooms are not avaialable"); }
        }
      
    }
}
