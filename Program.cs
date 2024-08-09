using System;
using ShoppingCart.Model;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "Kavya");
           
            Product product1 = new Product(1, "Chocolate",30 , 5);
            Product product2 = new Product(2, "Snacks", 40, 10);
            Product product3 = new Product(3, "Books", 100, 20);
            Product product4 = new Product(4, "Paint", 200, 30);

            LineItem lineItem1 = new LineItem(1, product1, 2); // 2 Chocolate
            LineItem lineItem2 = new LineItem(2, product2, 3); // 3 Snacks
            LineItem lineItem3 = new LineItem(3, product3, 6);
            LineItem lineItem4 = new LineItem(4, product4, 5);

            List<LineItem> items1 = new List<LineItem>();
            items1.Add(lineItem1);
            items1.Add(lineItem2);
            //items1.Add(lineItem3);
            //items1.Add(lineItem4);

            List<LineItem> items2 = new List<LineItem>();
            //items2.Add(lineItem1);
            //items2.Add(lineItem2);
            items2.Add(lineItem3);
            items2.Add(lineItem4);

            Order order1 = new Order(1,items1 ,DateTime.Now);
            Order order2 = new Order(2, items2, DateTime.Now);

            customer.Orders.Add(order1);
            customer.Orders.Add(order2);

            Console.WriteLine($"Customer: {customer.CustomerName}");
            
            PrintDetails(customer);
        }
        public static void PrintDetails(Customer customer)
        {
            Console.WriteLine($"Customer ID : {customer.CustomerId} \n" +
                $"Customer Name: {customer.CustomerName}");
            Console.WriteLine();
            Console.WriteLine($"Order Details");

            foreach (var order in customer.Orders)
            {
                Console.WriteLine("_________________________________________________________________________________________________________________________________________");
                Console.WriteLine($"| Order Id: {order.OrderId,123} |\n| Order Time: {order.Date,121} |");
                //Console.WriteLine();
                Console.WriteLine($"| LineItem Details {"|",118}");
                Console.WriteLine("|-----------|----------------|----------------------|----------|------------|-----------|--------------------------|--------------------|");
                Console.WriteLine("| Line Item |   Product ID   |  Product Name        | Quantity | Unit Price | Discount  | Unit Cost after Discount | Total Lineitem Cost|");
                Console.WriteLine("|-----------|----------------|----------------------|----------|------------|-----------|--------------------------|--------------------|");


                foreach (var item in order.LineItems)
                {
                    Console.WriteLine($"| {item.LineItemId,-9} | {item.Product.ProductId,-14} | {item.Product.ProductName,-20} | {item.Quantity,8} | {item.Product.ProductPrice,10}" +
                        $" | {item.Product.DiscountedPrice,7}%  | {item.Product.CalculateDiscount(),24} | {item.CalculateLineItemCost(),19}|");
                }
                Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------------------------|");
                Console.WriteLine($"| Total Order Value:                                                                                                 {order.CalculateOrderPrice(),19}|");
                Console.WriteLine("\n\n");
            }
        }
    }
}



