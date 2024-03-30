using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefententamen_opgave
{
    class FootballPlayer
    {
        protected string name;
        protected int age;

        public FootballPlayer(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual int CalculateTransferValue()
        {
            return (27 - this.age) * 2;
        }

        public override string ToString()
        {
            return $"{this.name} ({this.age}), transfervalue: {this.CalculateTransferValue()}m";
        }
    }
}
