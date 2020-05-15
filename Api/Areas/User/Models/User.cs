using System;
using Microsoft.AspNetCore.Identity;

namespace Api.Areas.User.Models
{
    public class User : IdentityUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}