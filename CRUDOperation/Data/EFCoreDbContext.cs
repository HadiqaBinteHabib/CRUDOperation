using CRUDOperation.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperation.Data;

    public class EFCoreDbContext : DbContext
    {

    public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options):base(options) 
    {
        
    }

    //Dbset

    public DbSet<Category> Categories { get; set; }

    public DbSet<Product> Products { get; set; }


}

