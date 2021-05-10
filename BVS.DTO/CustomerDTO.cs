using System;
using System.Collections.Generic;

namespace BVS.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public DateTime Birthdate { get; set; }
        public IEnumerable<CustomerVideoDTO> CustomerVideos { get; set; }
    }
}