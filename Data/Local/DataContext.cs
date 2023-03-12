using EgweneService.Data.Local.Entities;
using Microsoft.EntityFrameworkCore;

namespace EgweneService.Data.Local;

public class DataContext : DbContext
{
/*
    public DataContext() : base()
    {
        
        
    }*/

    public DbSet<Character> Characters { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<QuestPoint> QuestPoints { get; set; }
    public DbSet<Server> Servers { get; set; }

    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(Configuration.GetConnectionString("EgweneDb"));
    }
    

    

}