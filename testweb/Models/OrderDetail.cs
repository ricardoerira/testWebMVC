using System;
namespace testweb.Models
{
    public class OrderDetail
    {
       
            public int id { get; set; }
            public int productid { get; set; }
            public int orderid { get; set; }
            public int quantity { get; set; }
            public virtual Product product { get; set; }
            public virtual Order Order { get; set; }


    }
}
