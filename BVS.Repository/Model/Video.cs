using BVS.DTO.Enum;
using System;
using System.Collections.Generic;

namespace BVS.Repository.Model
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int DayRentLimit { get; set; }
        public int MaxQuantity { get; set; }

        public ICollection<CustomerVideo> CustomerVideos { get; set; }
    }
}