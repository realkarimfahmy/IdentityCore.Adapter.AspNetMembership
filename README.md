
# IdentityCore.Adapter.AspNetMembership

is a Adapter library that enables you to use [Microsoft Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-6.0&tabs=visual-studio) with existing code base using AspNetMembership user management
to have several new features like Two-Factor Authentication, Account Lockout, Account Confirmation, Password Reset, Security Stamp (Sign-Out Everywhere) and external login with existing Facebook, Google, Twitter or Live login.

Before, these features had to be coded,

so now developers can focus more on main business while using tested and standardized method to manage users.


## Required

.Net 6 Framework


## Installation

Install by Nuget

```bash
  dotnet add package IdentityCore.Adapter.AspNetMembership
```
    
## Usage

if you are using the default schema of AspNetMemberShip without any customization

as well you can include identity options.
```csharp
services.AddIdentityAdapter(SqlConnectionString);

//or

services.AddIdentityAdapter(SqlConnection, opts =>
            {
                opts.Password.RequiredLength = 8;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireDigit = true;
            }); 
```
if you are using the customize schema of AspNetMemberShip create your own `CustomUserStore.cs` and `CustomRoleStore.cs` to adapted your customization  
```csharp
services.AddIdentityAdapter(SqlConnection, opts =>
            {
                opts.Password.RequiredLength = 8;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = true;
                opts.Password.RequireDigit = true;
            }).AddUserStore<CustomUserStore>()
              .AddRoleStore<CustomRoleStore>(); 
```


# Hi, I'm Karim Fahmy! 👋


## 🔗 Links
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/realkarimfahmy/)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/realkarimfahmy)

