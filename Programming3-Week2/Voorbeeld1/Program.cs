namespace Voorbeeld1
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

            Werknemer werknemer = new Werknemer("Wouter", "Zwart", 4000f);
            werknemer.VerhoogSalaris(150);

            Directeur directeur = new Directeur("Wouter", "Zwart", 10000f);
            directeur.VerhoogSalaris(150);

            Console.WriteLine($"Dir: {directeur.salaris}, Werk: {werknemer.salaris}");
            Console.WriteLine($"{directeur.ToString()}");
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