using Microsoft.EntityFrameworkCore;

namespace EgweneService.Data.Local;

public class RestBuilder
{

    private readonly WebApplication _app;

    public RestBuilder(WebApplication app)
    {
        _app = app;
    }

    public void SetupRestEnpoints()
    {
        _app.MapGet("characters", async (DataContext db) => await db.Characters.ToListAsync());
        _app.MapGet("quests", async (DataContext db) => await db.Quests.ToListAsync());
        _app.MapGet("questpoints", async (DataContext db) => await db.QuestPoints.ToListAsync());
        _app.MapGet("servers", async (DataContext db) => await db.Servers.ToListAsync());

    }
    
    
    

}