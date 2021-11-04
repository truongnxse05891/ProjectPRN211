using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public int Quality { get; set; }
        public DateTime OrderDate { get; set; }
        public bool Status { get; set; }
    }
}
