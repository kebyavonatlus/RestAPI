using Microsoft.EntityFrameworkCore;

namespace RestAPI.Models
{
    public class CmsShoppingCartContext : DbContext
    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options) : base (options)
        {
        }

        public DbSet<Page> Pages { get; set; }
    }
}
