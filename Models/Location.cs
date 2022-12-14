using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BTLNet2_Nhom11.Models
{
    public partial class Location
    {
        
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
        public int? Levels { get; set; }
        public string Slug { get; set; }
        public string NameWithType { get; set; }
        public string Type { get; set; }
       
        public virtual Customer Customer { get; set; }
    }
}
