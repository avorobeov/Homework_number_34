﻿using System;
using System.Collections.Generic;

namespace Homework_number_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> clients = new Queue<int>();

            int numberClients = 10;

            FillQueue(clients, numberClients);

            ServeClient(clients);
        }

        private static void ServeClient(Queue<int> clients)
        {
            int balance = 0;

            while (clients.Count > 0)
            {
                Console.WriteLine($"Клиент сделал оплату в кассу добавилось {clients.Peek()} рублей.");

                balance += clients.Dequeue();

                Console.WriteLine($"\nКаса вашего магазина ровняется {balance} рублей");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static void FillQueue(Queue<int> clients, int numberClients)
        {
            Random random = new Random();

            int minValue = 10;
            int maxValue = 100;

            for (int i = 0; i < numberClients; i++)
            {
                clients.Enqueue(random.Next(minValue, maxValue));
            }
        }
    }
}
