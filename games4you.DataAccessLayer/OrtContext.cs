using Microsoft.EntityFrameworkCore;
namespace games4youDomain; 
public class OrtContext : DbContext
{
        public OrtContext(DbContextOptions<OrtContext> options) : base(options)
    {
    }
    public DbSet<Ort> Orts { get; set; }
    
}