using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTLNet2_Nhom11.Models;
#nullable disable

namespace BTLNet2_Nhom11.ModelViews
{
    public class XemDonHang
    {
        [Key]
        public int Id { get; set; }
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
