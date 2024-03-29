﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity
{
    // Order, Id, UserId,OrderDateTine,İsDelete
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool IsStatus { get; set; } = false;
        public DateTime OrderDateTime { get; set; } = DateTime.Now;
        public bool IsDelete { get; set; }

        public List<SellProduct> SellProductList { get; set; }

        public double ThisOrderTotalPrice
        {
            get
            {
                double total = 0;
                foreach (var item in SellProductList)
                {
                    total += item.TotalPrice;
                }
                return total;
            }
        }
    }
}
