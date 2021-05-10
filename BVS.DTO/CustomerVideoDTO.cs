using System;
using System.Collections.Generic;

namespace BVS.DTO
{
    public class CustomerVideoDTO
    {
        public int Id { get; set; }

        public int VideoId { get; set; }
        public VideoDTO Video { get; set; }

        public int CustomerId { get; set; }
        public CustomerDTO Customers { get; set; }
        public bool IsActive { get; set; }
        public DateTime RentDate { get; set; }
    }
}