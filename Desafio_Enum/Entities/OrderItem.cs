using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Enum.Entities
{
    internal class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem()
        { 
        }

        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return (double)Quantity * Price;
        }

        public override string ToString()
        {
            return $"Nome: {Product.Name}, Preço: {Price:C}, Quantidade: {Quantity}, Subtotal: {SubTotal():C}";
        }
    }
}
