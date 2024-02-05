using System;
namespace progettoClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "Luca";

            var order = new Order();
            customer.Orders = new List<Order>();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
