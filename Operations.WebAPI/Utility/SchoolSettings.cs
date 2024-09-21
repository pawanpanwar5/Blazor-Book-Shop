using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Operations.WebAPI.Utility
{
    public class SchoolSettings
    {
        public string SchoolName { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string City { get; set; }
        public string ISDCode { get; set; }
    }
}
