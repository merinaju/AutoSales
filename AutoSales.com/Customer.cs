using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSales.com
{
    public class Customer
    {
        #region Variables
        private static int lastCustomerNumber=0;
        #endregion
        public enum customerType { Admin, Guest, Private, Dealer  };
        #region properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string emailaddress { get; set; }
        public string streetAddress { get; set; }
        public string State { get; set; }
        public int zip { get; set; }
        [Key]
        public int customerID { get; private set; }
        public customerType TypeOfCustomer { get; set; }
        #endregion

        
    }
}
