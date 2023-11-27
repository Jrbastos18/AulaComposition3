using Aula132ExFixEnumEComposition.Entities.Enums;
using Aula132ExFixEnumEComposition.Entities;
using System.Globalization;

namespace Aula132ExFixEnumEComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inserindo os dados do cliente
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //Inserindo os dados do pedido
            Console.WriteLine("Enter order Data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); //Convertendo a string digitada para a variavel do tipo enum(OrderSatus), Console.Readline é a string a ser convertida
            
            //Instanciando os objetos
            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Instanciando o objeto Product
                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                //Instanciando o objeto OrderItem
                OrderItem orderItem = new OrderItem(quantity, price, product);
                
                //Inserindo o produto no Order
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}