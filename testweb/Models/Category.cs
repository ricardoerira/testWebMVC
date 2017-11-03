using System;
using System.Collections.Generic;

namespace testweb.Models
{
    public class Category
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Product> products { get; set; }


    }
}
