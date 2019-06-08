using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Project
{
    public class ClientClass
    {
        public ClientClass() { }

        public int idClient { get; set; }
        public string firstNameClient { get; set; }
        public string lastNameClient { get; set; }
        public string addressClient { get; set; }
        public string companyClient { get; set; }
        public string phoneClient { get; set; }
        public string emailClient { get; set; }
        public string postalCodeClient { get; set; }
        public string paymentClient { get; set; }
        public DateTime createdClient { get; set; }
        public DateTime updatedClient { get; set; }
        public string cityClient { get; set; }
        public string countryClient { get; set; }
    }
}
