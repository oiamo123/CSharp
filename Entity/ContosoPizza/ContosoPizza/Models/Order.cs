﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<OrderDetail> Orderdetails { get; set; } = null!;
    }
}
