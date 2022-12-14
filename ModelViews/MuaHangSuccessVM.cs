using System;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace BTLNet2_Nhom11.ModelViews
{
    public class MuaHangSuccessVM
    {
        [Key]
        public int DonHangID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PhuongXa { get; set; }
        public string QuanHuyen { get; set; }
        public string TinhThanh { get; set; }

    }
}
