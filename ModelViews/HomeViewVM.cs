using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTLNet2_Nhom11.Models;
#nullable disable
namespace BTLNet2_Nhom11.ModelViews
{
    public class HomeViewVM
    {
        
        public List<TinDang> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        [Key]
        public int Id { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
