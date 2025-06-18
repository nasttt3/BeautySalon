using BeautySalon.Model;
using Microsoft.EntityFrameworkCore;

namespace BeautySalon.DataBase;

public class BeautySalonContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Master> Masters { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<FeedBack> FeedBacks { get; set; }
    public DbSet<RecordOfService> RecordOfServices { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data source=BeautySalon.db");
    }
}