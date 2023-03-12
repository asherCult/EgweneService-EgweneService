using EgweneService.Data.Local.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace EgweneService.Data.Local;

public class DataContext : DbContext
{

    public DbSet<Character> Characters { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<QuestPoint> QuestPoints { get; set; }
    public DbSet<Server> Servers { get; set; }

    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
        var dbCreator = (RelationalDatabaseCreator) Database.GetService<IDatabaseCreator>();
        dbCreator.EnsureCreated();

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("EgweneDb"));

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    
    

    

}