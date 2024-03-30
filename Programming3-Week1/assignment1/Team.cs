using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Team
    {
        List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }

        public void PrintAllTeamMembers()
        {
            for (int i = 0; i < programmers.Count; i++)
            {
                Console.WriteLine($"Name: {programmers[i].name}, Specialty: {programmers[i].specialty}");
            }
        }
    }
}
