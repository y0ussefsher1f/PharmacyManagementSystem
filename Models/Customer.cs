using Newtonsoft.Json;

namespace PharmacyManagementSystem.Models
{
    public class Customer
    {
        private int customerID;
        private string name;
        private string contact;
        private string email;

        [JsonConstructor]
        public Customer(int customerID, string name, string contact, string email)
        {
            this.customerID = customerID;
            this.name = name;
            this.contact = contact;
            this.email = email;
        }

        public Customer(int customerID, string name, string contact)
        {
            this.customerID = customerID;
            this.name = name;
            this.contact = contact;
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            return $"ID: {customerID}, Name: {name}, Contact: {contact}, Email: {email}";
        }
    }
}