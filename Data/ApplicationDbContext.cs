using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Project_BookStore.Models;

namespace MVC_Project_BookStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Category> categories { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}