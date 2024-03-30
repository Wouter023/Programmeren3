using Model;
using ReservationSystemService;

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
            CustomerService cs = new CustomerService();
            Console.WriteLine($"testing CustomerService");
            Customer customer = cs.GetById(ReadInt($"Enter customer id: "));
            Console.WriteLine($"{customer.FullName} ({customer.EmailAddress})");

            BookService bs = new BookService();
            Console.WriteLine($"testing BookService");
            List<Book> books = bs.GetByAuthor(ReadString($"Enter name of author: "));
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
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