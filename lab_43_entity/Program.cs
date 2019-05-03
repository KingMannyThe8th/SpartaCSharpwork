using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_43_entity
{
    class Program
    {
        Customer customerToUpdate;

        static Customer findOneCustomer;
        static void Main(string[] args)

        {
            //using - automatically cleans up database connection when done
            using (var db = new NorthwindEntities())
            {
                var customers = db.Customers.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.CustomerID);
                }

                foreach (var c in customers)
                {
                    Console.WriteLine($"ID is {c.CustomerID}, name is {c.ContactName}");
                }

                //customerToUpdate = db.Customers.Where(cust => cust.CustomerID == "Phill");

                //customerToUpdate.City = "PhilsCity";

                db.SaveChanges();

                try
                {
                    //contact database
                }
                catch {//any errors 
                   }

            finally {//close database 
                }
            }

            using (var db = new NorthwindEntities())
            {
                findOneCustomer =
                 (from cust in db.Customers
                  where cust.CustomerID == "Phil1"
                  select cust).FirstOrDefault();
                Console.WriteLine($"\n\nUpdated customer has new city = {findOneCustomer.City}");
            }
        }
    }

}
