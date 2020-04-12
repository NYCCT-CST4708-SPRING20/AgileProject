using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Models
{
    class Account
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }

        public Account() {}

        public Account(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
    }
}
