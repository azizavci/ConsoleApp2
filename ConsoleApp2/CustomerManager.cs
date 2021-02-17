using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("CUSTOMER ID:" + customer.Id);
            Console.WriteLine("CUSTOMER NAME:" + customer.CustomerName);
            Console.WriteLine("CUSTOMER ADDRESS:" + customer.CustomerAdres);
            Console.WriteLine("CUSTOMER GENDER:" + customer.Gender);
            Console.WriteLine("CUSTOMER ADDED!");
            Console.WriteLine("-----------------------------------------");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine("CUSTOMER ID:" + customer.Id);
            Console.WriteLine("CUSTOMER NAME:" + customer.CustomerName);
            Console.WriteLine("CUSTOMER ADDRESS:" + customer.CustomerAdres);
            Console.WriteLine("CUSTOMER GENDER:" + customer.Gender);
            Console.WriteLine("CUSTOMER REMOVED!");
            Console.WriteLine("-----------------------------------------");
        }

        public void Read(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("CUSTOMER ID:" + customer.Id);
                Console.WriteLine("CUSTOMER NAME:" + customer.CustomerName);
                Console.WriteLine("CUSTOMER ADDRESS:" + customer.CustomerAdres);
                Console.WriteLine("CUSTOMER GENDER:" + customer.Gender);
                Console.WriteLine("-----------------------------------------");

            }
        }
    }
}