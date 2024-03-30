namespace Model
{
    public class Customer
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public Customer(int id, string firstName, string lastName, string emailAddress) { 
            this.id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return $"{FullName} ({EmailAddress})";
        }
    }
}