using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRWebApplication.Model
{
    public class SuperUser
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Website { get; set; }
    }
}
