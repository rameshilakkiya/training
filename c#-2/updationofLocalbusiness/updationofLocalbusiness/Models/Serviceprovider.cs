using System;
using System.Collections.Generic;

namespace updationofLocalbusiness.Models
{
    public partial class Serviceprovider
    {
        public Serviceprovider()
        {
            Servicebookings = new HashSet<Servicebooking>();
        }

        public int Id { get; set; }
        public int Serviceid { get; set; }
        public int Userid { get; set; }
        public string Status { get; set; } = null!;
        public DateTime Date { get; set; }
        public int? Rating { get; set; }
        public string? Comment { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Users1 User { get; set; } = null!;
        public virtual ICollection<Servicebooking> Servicebookings { get; set; }
    }
}
