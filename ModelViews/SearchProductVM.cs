using System;
using System.ComponentModel.DataAnnotations;
#nullable disable
namespace BTLNet2_Nhom11.ModelViews
{
    public class SearchProductVM
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? Price { get; set; }
        public string Thumb { get; set; }
        public string Alias { get; set; }
    }
}
