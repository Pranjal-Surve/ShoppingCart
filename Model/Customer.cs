using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ShoppingCart.Model
{
    internal class Customer
    {
        public int CustomerId { get;  set; }
        public string CustomerName { get;  set; } 
        public List<Order> Orders = new List<Order>();

        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }
      
    }
}
