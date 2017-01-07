using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InMemoryDatabaseAspNetCore.Model
{
    /// <summary>
    /// An entity framework database context with implementation of ASP.NET Identity dbcontext.
    /// </summary>
    public class InMemoryContext : IdentityDbContext<ApplicationUser> 
    {
        
        public InMemoryContext(DbContextOptions options) : base(options)
        {
        }
       
    }

   
}