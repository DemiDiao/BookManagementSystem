﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBizMS.BLL
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ClientName { get; set; }
        public string BookName { get; set; }
        public int Quantity { get; set; }
        
    }
     
}
