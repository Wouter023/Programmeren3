using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Ticket
    {
        private string movieName;
        private int cinemaRoom;
        private DateTime startTime;
        private decimal price;
        private int minimunAge;

        public string MovieName
        {
            get { return movieName; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Error occured: Empty movie name!");
                }
                movieName = value; 
            }
        }
        public int CinemaRoom { 
            get { return cinemaRoom; }
            set {
                if (value > 5 || value < 1)
                {
                    throw new Exception($"Error occured: Invalid cinema room ({value})!");
                }
                cinemaRoom = value; 
            }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                if ((value.Minute != 30) && (value.Minute != 0))
                {
                    throw new Exception($"Error occured: Invalid start time! ({startTime})");
                }
                startTime = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public int MinimunAge
        {
            get { return minimunAge; }
            set {
                if (value != 6 && value == 9 && value == 12 && value == 16 && value == 0)
                {
                    throw new Exception($"Error occured: Invalid minimum age ({value})");
                }
                minimunAge = value;
            }
        }

        public bool Discount
        {
            get
            {
                if (StartTime.DayOfWeek == DayOfWeek.Monday || StartTime.DayOfWeek == DayOfWeek.Wednesday)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
        }
    }
}
