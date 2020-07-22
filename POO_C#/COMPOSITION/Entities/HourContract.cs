using System;

namespace COMPOSITION.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {           
        }

        public HourContract(DateTime time, double valuePerHour, int hours)
        {
             Date = time;
             ValuePerHour = valuePerHour;
             Hours = hours;
        }


        public double TotalValue(){
            return  Hours * ValuePerHour;
        
    }
}