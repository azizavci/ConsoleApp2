using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                CustomerName = "Kareem",
                CustomerAdres = "Alabama",
                Gender = "Man"
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                CustomerName = "Alicia",
                CustomerAdres = "North Carolina",
                Gender = "Woman"
            };
            Customer customer3 = new Customer()
            {
                Id = 3,
                CustomerName = "Cedric",
                CustomerAdres = "New York",
                Gender = "Man"
            };
            Customer customer4 = new Customer()
            {
                Id = 4,
                CustomerName = "Annah",
                CustomerAdres = "Wisconsin",
                Gender = "Woman"
            };
            Customer customer5 = new Customer()
            {
                Id = 5,
                CustomerName = "Jacop",
                CustomerAdres = "Michigan",
                Gender = "Man"
            };
            Customer customer6 = new Customer()
            {
                Id = 6,
                CustomerName = "Jacop",
                CustomerAdres = "Michigan",
                Gender = "Man"
            };

            Customer[] customers = new Customer[]
            {
                customer1,
                customer2,
                customer3,
                customer4,
                customer5,
                customer6
            };

            Customer customer7 = new Customer()
            {
                Id = 7,
                CustomerName = "Ethan",
                CustomerAdres = "Nevada",
                Gender = "Man"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer7);
            customerManager.Remove(customer6);
            customerManager.Read(customers);

        }
    }
}
