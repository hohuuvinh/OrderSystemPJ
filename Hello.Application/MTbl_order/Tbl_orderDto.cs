using System;
using System.Collections.Generic;
using System.Text;

namespace Hello.Application.MTbl_order
{
    public class Tbl_orderDto
    {
        public int id { get; set; }
        public float discount { get; set; }
        public int quanlity { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string image { get; set; }
        public int category { get; set; }
    }
}
