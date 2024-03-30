using System.Globalization;

namespace assignment2
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

            try
            {
                Customer customer1 = new Customer("Lionel Messi", new DateTime(1987, 6, 24));
                PrintCustomer(customer1);
                Customer customer2 = new Customer("Piet Paulusma", new DateTime(1956, 12, 15));
                PrintCustomer(customer2);

                Ticket ticket1 = new Ticket("Bohemian Rapsody", 10.5m)
                {
                    CinemaRoom = 1,
                    StartTime = new DateTime(2021, 2, 13, 21, 30, 0),
                    MinimunAge = 6
                };
                ticket1.CinemaRoom = 1;
                ticket1.StartTime = new DateTime(2021, 2, 13, 21, 30, 0);
                ticket1.MinimunAge = 6;

                Ticket ticket2 = new Ticket("The Prodigy", 10.5m)
                {
                    CinemaRoom = 4,
                    StartTime = new DateTime(2021, 2, 13, 22, 0, 0),
                    MinimunAge = 16
                };

                Ticket ticket3 = new Ticket("Green Book", 10.5m)
                {
                    CinemaRoom = 5,
                    StartTime = new DateTime(2021, 2, 15, 19, 0, 0),
                    MinimunAge = 12
                };

                Reservation reservation1 = new Reservation(customer1);
                reservation1.Ticket.Add(ticket1);
                reservation1.Ticket.Add(ticket2);
                reservation1.Ticket.Add(ticket3);

                Reservation reservation2 = new Reservation(customer2);
                reservation2.Ticket.Add(ticket1);
                reservation2.Ticket.Add(ticket2);
                reservation2.Ticket.Add(ticket3);

                PrintReservation(reservation1);
                PrintReservation(reservation2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        void PrintCustomer(Customer customer)
        {
            string discount = "no";
            if (customer.Discount)
            {
                discount = "yes";
            }
            Console.WriteLine($"{customer.Name}\ndate of birth: {customer.DateOfBirth:dd/MM/yyyy}\nage: {customer.Age}\ndiscount: {discount}");
        }

        void PrintReservation(Reservation reservation)
        {
            Console.WriteLine($"creating tickets (for {reservation.Customer.Name})");
            for (int i = 0; i < reservation.Ticket.Count; i++)
            {
                Console.WriteLine($"created ticket '{reservation.Ticket[i].MovieName}', start time: {reservation.Ticket[i].StartTime:dd/MM/yyyy HH:mm}, price: {reservation.Ticket[i].Price:0.00}, room: {reservation.Ticket[i].CinemaRoom} ({reservation.Ticket[i].MinimunAge}+)");
            }
            Console.WriteLine($"total price of reservation: {reservation.TotalPrice:00.00}");
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