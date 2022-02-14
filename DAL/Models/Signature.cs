using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Signature
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public int? IssureId { get; set; }
        public int? RecieverId { get; set; }

        public virtual User Issure { get; set; }
        public virtual User Reciever { get; set; }
    }
}
