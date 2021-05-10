using System;
using System.Collections.Generic;

namespace BVS.Repository.Model
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public DateTime Birthdate { get; set; }
        public ICollection<CustomerVideo> CustomerVideos { get; set; }
    }
}