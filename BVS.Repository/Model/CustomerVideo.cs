using System;
using System.Collections.Generic;

namespace BVS.Repository.Model
{
    public class CustomerVideo
    {

        public int Id { get; set; }

        public int VideoId { get; set; }
        public Video Video { get; set; }

        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public bool IsActive { get; set; }
        public DateTime RentDate { get; set; }

    }
}