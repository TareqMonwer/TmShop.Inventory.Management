﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmShop.Inventory.Management.Domain.OrderManagement
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderFulfilmentDate { get; private set; }
        public List<OrderItem> OrderItems { get; }

        public bool Fulfilled { get; set; } = false;

        public Order()
        {
            Id = new Random().Next(999999);

            int numberOfSeconds = new Random().Next(100);
            OrderFulfilmentDate = DateTime.Now.AddSeconds(numberOfSeconds);

            OrderItems = new List<OrderItem>();
        }
    }
}