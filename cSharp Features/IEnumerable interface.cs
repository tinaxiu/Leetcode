using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cSharp_Features
{
    class IEnumerable_interface
    {
        public class Customer
        {
            public string Name { get; set; }
            public string City { get; set; }
            public long Mobile { get; set; }
            public double Amount { get; set; }
        }

        Customer[] customers = new Customer[]
            {

                new Customer {Name="Vithal Wadje",City="Mumbai",Mobile=99999,Amount=89.45 },
                new Customer { Name = "Sudhir Wadje", City = "Latur", Mobile = 88888, Amount =426.00 },
                new Customer { Name = "Anil", City = "Delhi", Mobile = 777777, Amount = 5896.20 }
            };


        public IEnumerable<Customer> GetAllCustomer()
        {
            return customers;
        }

        public void solution()
        {
            foreach (var cust in GetAllCustomer())
            {
                Console.WriteLine("Name: " + cust.Name + "<br> " + "City: " + cust.City + " <br> "
                          + "Mobile " + cust.Mobile + "<br> " + "Amount :" + cust.Amount.ToString("c") + "<br>" + "-----" + "<br>");
            }

        }

    }
}
