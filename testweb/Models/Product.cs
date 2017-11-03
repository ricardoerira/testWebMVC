using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace testweb.Models
{
    public class Product
    {
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        [Display(Name = "Price")]
        public int price { get; set; }
        [Display(Name = "Category")]
        public int categoryid { get; set; }
        public virtual Category category { get; set; }


    }
}
