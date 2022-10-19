using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
   public enum CustomerType
    {
        Basic,Premium,Gold
    }
    public class Customer
    {
        public string CustID { get; set; }
        public string CustName { get; set; }
        public CustomerType CustomerType { get; set; }
        public List<Customer> Customers { get; set; }
    }

}
