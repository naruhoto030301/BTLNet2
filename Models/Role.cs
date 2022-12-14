using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable


namespace BTLNet2_Nhom11.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
