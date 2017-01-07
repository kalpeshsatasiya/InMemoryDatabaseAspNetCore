using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InMemoryDatabaseAspNetCore.Model
{

    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }

    }
}
