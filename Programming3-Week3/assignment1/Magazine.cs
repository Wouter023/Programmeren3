using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Magazine : BookStoreItem
    {
        private DaysOfWeek releaseDay;

        public DaysOfWeek ReleaseDay
        {
            get { return releaseDay; }
            set { releaseDay = value; }
        }

        public Magazine(string title, float price, DaysOfWeek releaseDay, int count) : base(title, price, count)
        {
            this.releaseDay = releaseDay;
        }


        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day:{releaseDay}, {Price:0.00} ({Count}x)");
        }
    }
}
