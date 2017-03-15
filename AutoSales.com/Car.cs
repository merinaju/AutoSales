using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSales.com
{
   public class Car
    {
        #region Variables
        private static int lastCarID=0;
        #endregion
        #region Properties
        public string TypeOfCar { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        [Key]
        public int CarID { get; private set; }
        public virtual  Customer Customer { get; set; }
        #endregion
       
    }
}
