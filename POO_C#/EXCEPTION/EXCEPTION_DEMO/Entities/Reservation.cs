using System;

namespace EXCEPTION_DEMO.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {            
        }

        public Reservation(int roomnumber, DateTime checkin, DateTime checkout )
        {
            RoomNumber = roomnumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        public int Duration() 
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut) 
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }


        public override string ToString() 
        {
            return " Room "
            + RoomNumber 
            + ", check-in: "
            + CheckIn.ToString("dd/MM/yyyy ")
            + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy ")
            + ", check-in: "
            + Duration()
            + " nights ";
        }

    }
}