using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTLNet2_Nhom11.Models;
#nullable disable
namespace BTLNet2_Nhom11.ModelViews
{
    public class ProductHomeVM
    {
        [Key]
        public int Id { get; set; }
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }
    }
}
