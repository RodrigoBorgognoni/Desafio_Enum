using System;
using Desafio_Enum.Entities;
using Desafio_Enum.Entities.Enums;

namespace Desafio_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client's data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine);

            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status (Pending_Payment/ Processing/ Shipped/ Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write(Environment.NewLine);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(Environment.NewLine);
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string p_name = Console.ReadLine();
                Console.Write("Product price: ");
                double p_price = double.Parse(Console.ReadLine());

                Product product = new Product(p_name, p_price);

                Console.Write("Quantity: ");
                int p_quant = int.Parse(Console.ReadLine());

                OrderItem orderitem = new OrderItem(product, p_quant, p_price);
                

                order.AddItem(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

        }
    }
}
