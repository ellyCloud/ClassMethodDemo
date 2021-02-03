using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        Customer customer = new Customer();
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added : " + customer.CustomerID + " " + customer.CustomerName);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerID + " " + customer.CustomerName + " is deleted from list");
        }
        public void ListCustomers(Customer[] customers)
        {
            Console.WriteLine("Customers are listed : ");
            foreach (Customer customer in customers)
            {
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Customer ID : " + customer.CustomerID);
                Console.WriteLine("Customer Name : " + customer.CustomerName);
                Console.WriteLine("Wanted Product Name : " + customer.ProductName);
                Console.WriteLine("Customer's Budget : " + customer.CustomerBudget);
                Console.WriteLine("Suggested Product's Cost : " + customer.SuggestedProductCost);
                Console.WriteLine("-----------------------------------------------------");
            }
            
        }
    }
}
