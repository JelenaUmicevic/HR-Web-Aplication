using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRWebApplication.Model
{
    public class RegularUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string FullTime_PartTime { get; set; }
        public string WorkExperience { get; set; }
    }
}
