using System;
using System.Collections.Generic;

namespace LocalBusiness1.Models
{
    public partial class Role
    {
        public Role()
        {
            Users2s = new HashSet<Users2>();
        }

        public int Roleid { get; set; }
        public string Rolename { get; set; } = null!;

        public virtual ICollection<Users2> Users2s { get; set; }
    }
}
