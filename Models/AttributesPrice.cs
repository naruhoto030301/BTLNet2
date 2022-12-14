using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace BTLNet2_Nhom11.Models
{
    public partial class AttributesPrice
    {
        [Key]
        public int AttributesPriceId { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public bool Active { get; set; }

        public virtual Attribute Attribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
