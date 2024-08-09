using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ShoppingCart.Model
{
    internal class Product
    {
        private const double Divisor = 100;
        public int ProductId { get;  set; }
        public string ProductName { get;  set; }
        public double ProductPrice { get;  set; }
        public double DiscountedPrice { get;  set; }

        public Product(int productId, string productName, double productPrice, double discountedPrice)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            DiscountedPrice = discountedPrice;
        }
       
        public double CalculateDiscount()
        {
            if (ProductPrice == 0) return 0;
            return ProductPrice - (ProductPrice * (DiscountedPrice/ Divisor)); 
        }
    }
}





//using System;

//namespace ShoppingCart.Model
//{
//    internal class Product
//    {
//        private const int Divisor = 100; // Changed to constant and renamed for clarity
//        public int ProductId { get; private set; }
//        public string ProductName { get; private set; }
//        public double ProductPrice { get; private set; }
//        public double DiscountedPrice { get; private set; }

//        public Product(int productId, string productName, double productPrice, double discountedPrice)
//        {
//            ProductId = productId;
//            ProductName = productName;
//            ProductPrice = productPrice;
//            DiscountedPrice = discountedPrice;
//        }

//        public double GetDiscountedPrice()
//        {
//            return DiscountedPrice;
//        }

       
//    }
//}
