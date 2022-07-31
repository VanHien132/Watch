using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Watch.Models
{
    public class ApplicationUser: IdentityUser
    {
        public virtual List<Order> Orders { get; set; }
    }
}
