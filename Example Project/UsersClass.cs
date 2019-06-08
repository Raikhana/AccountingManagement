using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Project
{
    public class UsersClass
    {

        public UsersClass() { }

        public int userID { get; set; }
        public string firstNameUsers { get; set; }
        public string lastNameUsers { get; set; }
        public string emailUsers { get; set; }
        public string phoneUsers { get; set; }
        public string roleUsers { get; set; }
        public DateTime createdUsers { get; set; }
        public DateTime updatedUsers { get; set; }
        public string approvedUsers { get; set; }
        public string passwordUsers { get; set; }
    }
}
