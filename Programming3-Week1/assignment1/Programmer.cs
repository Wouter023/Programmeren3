using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Programmer
    {
        public string name;
        public Specialty specialty;
        public Programmer(string name)    
        {
            this.name = name;
            specialty = Specialty.Unknown;
        }
        public Programmer(string name, Specialty specialty)
            : this(name)
        {
            this.specialty = specialty;
        }

        public void Print(Programmer programmer)
        {
            Console.WriteLine($"Name: {programmer.name}, Specialty: {programmer.specialty}");
        }
    }
}
