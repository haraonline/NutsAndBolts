using Microsoft.EntityFrameworkCore;
using MyCoreRazorPages.Models;

namespace MyCoreRazorPages.AppDbContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //pass options to the DBContext base class
        {
            //this is important
        }
        public DbSet<Category> Category { get; set; }
    }
}