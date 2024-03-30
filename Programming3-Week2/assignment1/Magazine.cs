using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Magazine : BookStoreItem
    {
        public DaysOfWeek releaseDay;

        public Magazine(string title, float price, DaysOfWeek releaseDay) : base(title, price)
        {
            this.releaseDay = releaseDay;
        }


        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day:{releaseDay}, {Price:0.00}");
        }
    }
}
