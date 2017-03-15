using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoSales.com.Customer;

namespace AutoSales.com
{
   public static class Inventory
    {
        public static InventoryModel db = new InventoryModel();

        public static Customer FindCustomer(string emailaddress)
        {
            if(string.IsNullOrEmpty(emailaddress))
            {
                throw new ArgumentNullException("Email address cannot be empty");
            }
            return db.Customers.Where(c => c.emailaddress == emailaddress).FirstOrDefault();
        }
       
        public static Customer Register(string firstname, string lastname, string streetaddress, string state, int zip)
        {
            var customer = new Customer { FirstName = firstname,
                LastName = lastname,
                streetAddress = streetaddress,
                State = state,
                zip = zip
            };
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;

        }
        
       

    }
}
