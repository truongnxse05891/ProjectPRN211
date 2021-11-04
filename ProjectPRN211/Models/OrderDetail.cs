using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientAddress { get; set; }
        public int RecipientPhone { get; set; }
        public int ProductId { get; set; }
        public int Quality { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
