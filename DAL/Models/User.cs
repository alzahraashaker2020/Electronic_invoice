using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class User
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            DocumentIssuers = new HashSet<Document>();
            DocumentReceivers = new HashSet<Document>();
            SignatureIssures = new HashSet<Signature>();
            SignatureRecievers = new HashSet<Signature>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Identification { get; set; }
        public int? RoleId { get; set; }
        public int? SignatureId { get; set; }
        public int? ActivityTypeId { get; set; }

        public virtual ActivityType ActivityType { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Document> DocumentIssuers { get; set; }
        public virtual ICollection<Document> DocumentReceivers { get; set; }
        public virtual ICollection<Signature> SignatureIssures { get; set; }
        public virtual ICollection<Signature> SignatureRecievers { get; set; }
    }
}
