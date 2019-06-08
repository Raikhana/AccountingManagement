using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Project
{
     public class OrderClass
    {
        public OrderClass() { }

        public string selectedItemProduct { get; set; }
        public int ammountProduct { get; set; }
       
      
        public int idOrders { get; set; }
        public DateTime dateOrder { get; set; }
        public decimal subtotalOrders { get; set; }
        public decimal taxOrder { get; set; }
        public decimal totalOrder { get; set; }
        public int statusOrderId { get; set; }
        public string nameProduct { get; set; }
        public int client_id { get; set; }

       
    }
}
