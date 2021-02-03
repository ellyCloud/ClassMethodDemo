using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~Welcome to the system~~~~");


            Customer c1 = new Customer();
            c1.CustomerID = 2001;
            c1.CustomerName = "Chandler Bing";
            c1.ProductName = "Pinball Table";
            c1.CustomerBudget = 300;
            c1.SuggestedProductCost = 450;

            Customer c2 = new Customer();
            c2.CustomerID = 2002;
            c2.CustomerName = "Monica Geller";
            c2.ProductName = "Eyelash Curler";
            c2.CustomerBudget = 150;
            c2.SuggestedProductCost = 120;

            Customer c3 = new Customer();
            c3.CustomerID = 2003;
            c3.CustomerName = "Joey Tribbiani";
            c3.ProductName = "Duck";
            c3.CustomerBudget = 20;
            c3.SuggestedProductCost = 15;

            Customer c4 = new Customer();
            c4.CustomerID = 2004;
            c4.CustomerName = "Phoebe Buffay";
            c4.ProductName = "Guitar";
            c4.CustomerBudget = 500;
            c1.SuggestedProductCost = 499;

            Customer c5 = new Customer();
            c5.CustomerID = 2005;
            c5.CustomerName = "Rachel Green";
            c5.ProductName = "Fur";
            c5.CustomerBudget = 600;
            c5.SuggestedProductCost = 1000;

            Customer c6 = new Customer();
            c6.CustomerID = 2006;
            c6.CustomerName = "Ross Geller";
            c6.ProductName = "Dinosaur model";
            c6.CustomerBudget = 900;
            c6.SuggestedProductCost = 850;

            Customer[] customers = new Customer[] {c1,c2,c3,c4,c5,c6 };

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~Methods~~~~~~~~~~~~~~~~~~~~~~~");

            //instance
            Console.WriteLine();
            CustomerManager CManager = new CustomerManager();
            CManager.AddCustomer(c1);
            CManager.AddCustomer(c2);
            CManager.AddCustomer(c3);
            CManager.AddCustomer(c4);
            CManager.AddCustomer(c5);
            Console.WriteLine();
            Console.Write("Deletion Method : ");
            CManager.DeleteCustomer(c6);
            Console.WriteLine();

            CManager.ListCustomers(customers);






        }

    }
}
