using System;
using System.Collections.Generic;
using BVS.DTO.Enum;

namespace BVS.DTO
{
    public class VideoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public int DayRentLimit { get; set; }
        public int MaxQuantity { get; set; }

        public IEnumerable<CustomerVideoDTO> CustomerVideos { get; set; }
    }
}