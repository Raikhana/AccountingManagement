using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Project
{
    public class ProductClass
    {
        public ProductClass() { }

        public int idProduct { get; set; }
        public string nameProduct { get; set; }
        public string descriptionProduct { get; set; }
        public DateTime createdProduct { get; set; }
        public DateTime updatedProduct { get; set; }
        public double costProduct { get; set; }
        public string statusProduct { get; set; }
        public int idStatusProduct { get; set; }
        public int ammountProduct { get; set; }


    }
}
