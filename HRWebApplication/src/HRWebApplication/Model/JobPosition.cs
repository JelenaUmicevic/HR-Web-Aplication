using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRWebApplication.Model
{
    public class JobPosition
    {
        public string Name { get; set;}
        public string Description { get; set;}
        public string City { get; set; }
        public string Country { get; set; }
        public string PartTime_FullTime { get; set; }
    }
}
