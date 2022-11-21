using System;
using System.Collections.Generic;

namespace updationofLocalbusiness.Models
{
    public partial class Users1
    {
        public Users1()
        {
            Servicebookings = new HashSet<Servicebooking>();
            Serviceproviders = new HashSet<Serviceprovider>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public long Mobile { get; set; }
        public string City { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Zipcode { get; set; }
        public string Password { get; set; } = null!;
        public int Roleid { get; set; }
        public DateTime? Lastlogin { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Servicebooking> Servicebookings { get; set; }
        public virtual ICollection<Serviceprovider> Serviceproviders { get; set; }
    }
}
