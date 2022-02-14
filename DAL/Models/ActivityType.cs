﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Edescription { get; set; }
        public string Adescription { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
