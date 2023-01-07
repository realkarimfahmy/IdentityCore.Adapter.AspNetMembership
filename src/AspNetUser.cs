using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdentityCore.Adapter.AspNetMembership
{
    public class AspNetUser
    {
        public Guid ApplicationId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string LoweredUserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }
        [ForeignKey("UserId")]
        public virtual AspNetMembership AspNetMembership { get; set; }
        [ForeignKey("ApplicationId")]
        public virtual AspNetApplication AspNetApplication { get; set; }
    }
}
