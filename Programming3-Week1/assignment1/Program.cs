namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Programmer programmer1 = new Programmer("Peter", Specialty.Csharp);

            Team team = new Team();

            team.AddProgrammer(programmer1);
            team.AddProgrammer(new Programmer("Kevin", Specialty.Java));
            team.AddProgrammer(new Programmer("John", Specialty.Csharp));
            team.AddProgrammer(new Programmer("Susan", Specialty.Java));
            team.AddProgrammer(new Programmer("Emma"));
            team.PrintAllTeamMembers();
        }

        int ReadInt(string question)
        {
            Console.WriteLine(question);
            return int.Parse(Console.ReadLine());
        }

        int ReadInt(string question, int min, int max)
        {
            int value;
            do
            {
                value = ReadInt(question);
            }
            while (value < min || value > max);

            return value;
        }

        string ReadString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}