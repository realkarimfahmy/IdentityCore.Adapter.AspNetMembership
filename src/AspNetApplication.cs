

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityCore.Adapter.AspNetMembership
{
    public class AspNetApplication
    {
        [Key]
        public Guid ApplicationId { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
        public virtual ICollection<AspNetMembership> AspNetMemberships { get; set; }

        public AspNetApplication()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
            this.AspNetMemberships = new HashSet<AspNetMembership>();
        }
    }
}
