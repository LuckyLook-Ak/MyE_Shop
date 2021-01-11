using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyE_Shop.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }

    }
}