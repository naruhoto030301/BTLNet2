using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace BTLNet2_Nhom11.Models
{
    public partial class Shipper
    {
        [Key]
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public DateTime? ShipDate { get; set; }
    }
}
