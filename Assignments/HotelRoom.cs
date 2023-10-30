using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelRoom<T>
    {

        private int roomNumber;
        private T roomType;
        private bool status;

        public HotelRoom(int roomNumber, T roomType, bool status)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            Status = status;
        }

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public T RoomType { get => roomType; set => roomType = value; }
        public bool Status { get => status; set => status = value; }
    }
}
