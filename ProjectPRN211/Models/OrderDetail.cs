using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectPRN211.Models
{
    public partial class OrderDetail
    {
        private int v1;
        private string v2;
        private string v3;
        private int v4;
        private int v5;
        private int v6;
        private DateTime now;

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
