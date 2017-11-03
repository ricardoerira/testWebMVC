using System;
using System.Collections.Generic;

namespace testweb.Models
{
    public class Order
    {
       
            public int id { get; set; }
            public int customerid { get; set; }
            public int total { get; set; }
            public virtual Customer customer { get; set; }
            public virtual ICollection<OrderDetail> orderDetails { get; set; }


    }
}
