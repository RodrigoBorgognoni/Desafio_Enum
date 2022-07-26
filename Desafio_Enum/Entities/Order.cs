﻿using Desafio_Enum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Enum.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order Moment: {Moment:dd/MM/yyyy HH:mm:ss}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order Items: ");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item}");
            }

            sb.AppendLine($"Total Price: {Total():C}");
            return sb.ToString();
        }

    }
}
