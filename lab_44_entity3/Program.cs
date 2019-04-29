using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_44_entity3
{
    class Program
    {
        static List<Customer> customerList; //ALL/ List of customers - the STATIC allows us to refer to it at any point of our code
        static Customer customer; //ONE holds one customer
        static Customer newCustomer; //to ADD NEW CUSTOMER - will be able to reference this later on in code



        static void Main(string[] args)  //MAIN METHOD
        {
            //encapsulates database for easy cleanup afterwards
            using (var db = new NorthwindEntities())
            {
                //Standard LINQ enquiry
                customerList =
                (from c in db.Customers
                 select c).ToList<Customer>(); //Presence of 

                foreach (Customer c in customerList)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, " + $"Name : {c.ContactName}, City : {c.City}");
                }

                //select one customer & update 
                customer = db.Customers.Where(customer => customer.CustomerID == "FRANK").FirstOrDefault();
                customer.City = "BERLIN"; //changed to BERLIN 
                db.SaveChanges();




            }
            //CHECK IF UPDATE HAS WORKED AND QUERY THE DATABASE
            using (var db = new NorthwindEntities())
            {
                foreach (Customer c in db.Customers)
                {
                    Console.WriteLine($"ID : {c.CustomerID}, " + $"Name : {c.ContactName}, City : {c.City}");
                }
                //LINQ LAMBDA QUERY
                customer = db.Customers.Where(cust => cust.CustomerID == "FRANK").FirstOrDefault();
                Console.WriteLine($"{customer.CustomerID},{customer.ContactName},{customer.City}");

                //LINQ STANDARD 
                customer =
                    (from cust in db.Customers
                     where cust.CustomerID == "FRANK"
                     select cust).FirstOrDefault();   //IF TRYING TO GET 1 CUSTOMER, ENCAPSULATE query (add brackets)
                                                      //then add '.FirstOrDefault();

            }
            //INSERT NEW 
            using (var db = new NorthwindEntities())
            {
                newCustomer = new Customer()
                {
                    CustomerID = "Bobb6",
                    ContactName = "Bob",
                    CompanyName = "Sparta Global",
                    City = "London"


                };
                db.Customers.Add(newCustomer); //new customer has been added 
                db.SaveChanges(); //this has now been saved
            }
            //QUERY 
            using (var db = new NorthwindEntities()) 
            {
                customer = db.Customers.Where(cust => cust.CustomerID == "Bobb6").FirstOrDefault();
                Console.WriteLine($"Create new record: {customer.CustomerID}," +
                              $"{customer.ContactName},{customer.City}");

            }





            //DELETE RECORD 
            //SELECT FIRST
            using (var db = new NorthwindEntities())
            {
                customer = db.Customers.Where(cust => cust.CustomerID == "Bobb6").FirstOrDefault();

                //THEN DELETE CUSTOMER
                db.Customers.Remove(customer); //Deleting local copy of this customer
                db.SaveChanges();

            }

            //QUERY 
            using (var db = new NorthwindEntities())
            {
                customer = db.Customers.Where(cust => cust.CustomerID == "Bobb6").FirstOrDefault();

                if (customer != null)
                {
                    Console.WriteLine($"{customer.CustomerID}, "+
                        $"{customer.ContactName},{customer.City}");
                }
                else
                {
                    Console.WriteLine($"Customer Bobb6 does not exist");
                }

            }

        }  


    }
}
