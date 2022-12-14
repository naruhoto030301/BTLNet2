using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace BTLNet2_Nhom11.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            AttributesPrices = new HashSet<AttributesPrice>();
        }
        [Key]
        public int AttributeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttributesPrice> AttributesPrices { get; set; }
    }
}
