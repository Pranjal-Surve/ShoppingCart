using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ShoppingCart.Model
{
    internal class LineItem
    {
        public int LineItemId { get;  set; }
        public Product Product { get;  set; }
        public int Quantity { get; set; }

        public LineItem(int lineItemId, Product product, int quantity)
        {
            LineItemId = lineItemId;
            Product = product;
            Quantity = quantity;
        }

        public double CalculateLineItemCost()
        {
            return Product.CalculateDiscount() * Quantity;
        }
    }
}
