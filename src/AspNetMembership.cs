using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityCore.Adapter.AspNetMembership
{
    public class AspNetMembership
    {
        public Guid ApplicationId { get; set; }
        [Key]
        public Guid UserId { get; set; }
        public string Password { get; set; }
        public int PasswordFormat { get; set; }
        public string PasswordSalt { get; set; }
        public string Email { get; set; }
        public string LoweredEmail { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChangedDate { get; set; }
        public DateTime LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        public DateTime FailedPasswordAttemptWindowStart { get; set; }
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetApplication AspNetApplication { get; set; }
    }
}
