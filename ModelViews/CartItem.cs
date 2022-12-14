using System;
using System.ComponentModel.DataAnnotations;
using BTLNet2_Nhom11.Models;
#nullable disable
namespace BTLNet2_Nhom11.ModelViews
{
    public class CartItem
    {
        
        public Product product { get; set; }
        [Key]
        public int amount { get; set; }
        public double TotalMoney => amount * product.Price.Value;
    }
}
