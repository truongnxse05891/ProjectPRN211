using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Abstract { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int TypeId { get; set; }
        public int StoreId { get; set; }
        public string TimeOpen { get; set; }
        public string TimeClose { get; set; }
    }
}
