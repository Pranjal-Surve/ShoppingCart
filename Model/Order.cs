using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ShoppingCart.Model
{
    internal class Order
    {
        public int OrderId { get;  set; }
        public DateTime Date { get;  set; }
        public List<LineItem> LineItems { get;  set; }

        public Order(int orderId,List<LineItem> Lineitem ,DateTime date)
        {
            OrderId = orderId;
            Date = date;
            LineItems = Lineitem;
        }

        public void AddLineItem(LineItem lineItem)
        {
            LineItems.Add(lineItem);
        }

        public double CalculateOrderPrice()
        {
            double orderPrice = 0;
            foreach (LineItem lineItem in LineItems)
            {
                orderPrice= orderPrice + lineItem.CalculateLineItemCost();
            }
            return orderPrice;
        }
    }
}
