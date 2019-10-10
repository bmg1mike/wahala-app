using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Identity;

namespace wahalaApI.Models
{
    public class User:IdentityUser
    {
        public ICollection<Wahala> Wahalas { get; set; }
        public bool HasLeft { get; set; }

        public User() => Wahalas = new Collection<Wahala>();
    }
}