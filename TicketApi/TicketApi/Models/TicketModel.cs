using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.Models
{
    public class TicketModel
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int EventID { get; set; }
        public int Price { get; set; }
        public bool Paid { get; set; }
        public string Seat { get; set; }

      


    }
}
