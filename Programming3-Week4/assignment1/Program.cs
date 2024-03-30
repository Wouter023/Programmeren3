using Model;

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
            Customer customer1 = new Customer(1, "Lionel", "Messi", "lionelmessi@hotmail.com");
            Customer customer2 = new Customer(2, "Don", "Henley", "donhenley@gmail.com");
            Console.WriteLine($"testing customers");
            Console.WriteLine($"{customer1.ToString()}");
            Console.WriteLine($"{customer2.ToString()}");

            Book book1 = new Book(1, "Harry Potter and the Prisoner of Azkaban", "J.K. Rowling");
            Book book2 = new Book(2, "The Da Vince Code", "Dan Brown");
            Console.WriteLine($"testing books");
            Console.WriteLine($"{book1.ToString()}");
            Console.WriteLine($"{book2.ToString()}");

            Reservation reservation1 = new Reservation(1, customer1, book2);
            Reservation reservation2 = new Reservation(2, customer2, book2);
            Console.WriteLine($"testing reservations");
            Console.WriteLine($"{reservation1.ToString()}");
            Console.WriteLine($"{reservation2.ToString()}");
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