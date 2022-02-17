using _Order_Estudo.Entities;
using _Order_Estudo.Entities.Enums;
using System;
using System.Globalization;

namespace _Order_Estudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDay);
            Ordem order = new Ordem(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string name = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product product = new Product (name, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem = new OrderItem(quantity, price,product);
                order.AddItem(orderItem);
                
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            Console.WriteLine();


        }
    }
}
