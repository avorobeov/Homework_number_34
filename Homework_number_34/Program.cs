using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> clients = new Queue<int>();

            int numberClients = 10;
            int balance = 0;

            clients = FillQueue(clients, numberClients);

            while (clients.Count > 0)
            {
                balance = HandleClient(clients, balance);

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static int HandleClient(Queue<int> clients, int balance)
        {
            Console.WriteLine($"Клиент сделал оплату в кассу добавилось {clients.Peek()} рублей.");

            balance += clients.Dequeue();

            Console.WriteLine($"\nКаса вашего магазина ровняется {balance} рублей");

            return balance;
        }

        private static Queue<int> FillQueue(Queue<int> clients, int numberClients)
        {
            Random random = new Random();

            int minValue = 10;
            int maxValue = 100;

            for (int i = 0; i < numberClients; i++)
            {
                clients.Enqueue(random.Next(minValue, maxValue));
            }

            return clients;
        }
    }
}
