using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBizMS.BLL
{
    public class Book
    {
        public int BookID { get; set; }
        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Category { get; set; }
        public int YearPublishied { get; set; }
        public string Publisher { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }
        

    }
}
