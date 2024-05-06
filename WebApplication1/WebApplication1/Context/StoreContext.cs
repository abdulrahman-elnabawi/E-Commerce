//using entity framework core

using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities;

namespace WebApplication1.Context
{
    public class StoreContext : DbContext
    {
		public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
		}
		public DbSet<Product> Products { get; set; }
	}   
    {
        
    }
}