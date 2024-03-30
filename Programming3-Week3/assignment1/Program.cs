using System.Globalization;

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
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            BookStore bookStore = new BookStore();

            bookStore.Add(new Book("Dracula", "Bram Stoker", 15.00f, 5));
            bookStore.Add(new Book("Joe speedboot", "Tommy Wieringa", 12.50f, 5));
            bookStore.Add(new Magazine("Time", 3.90f, (DaysOfWeek)4, 10));
            bookStore.Add(new Magazine("Donald Duck", 2.50f, (DaysOfWeek)3, 8));
            bookStore.Add(new Book("The hobbit", "J.R.R. Tolkien", 12.50f, 4));

            bookStore.PrintCompleteStock();
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