using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Book_Store.Models
{
    public class Books
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public string category { get; set; }
        public string coverImage { get; set; }
        
        
    }
}