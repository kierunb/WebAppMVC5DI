using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppMVC5DI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}