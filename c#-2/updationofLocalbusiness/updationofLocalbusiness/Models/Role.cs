using System;
using System.Collections.Generic;

namespace updationofLocalbusiness.Models
{
    public partial class Role
    {
        public Role()
        {
            Users1s = new HashSet<Users1>();
        }

        public int Id { get; set; }
        public string Rolename { get; set; } = null!;

        public virtual ICollection<Users1> Users1s { get; set; }
    }
}
