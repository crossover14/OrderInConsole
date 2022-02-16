using _Order_Estudo.Entities;
using _Order_Estudo.Entities.Enums;
using System;

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
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDay);
            Ordem order = new Ordem(DateTime.Now, status, client);



        }
    }
}
