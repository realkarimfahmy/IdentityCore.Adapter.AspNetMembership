using Microsoft.AspNetCore.Identity;

namespace IdentityCore.Adapter.AspNetMembership
{
    public class AspNetMembershipUser : IdentityUser
    {
        public string PasswordSalt { get; set; }
        public int PasswordFormat { get; set; }
    }
}
