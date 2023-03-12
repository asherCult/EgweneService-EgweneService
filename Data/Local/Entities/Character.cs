using Microsoft.EntityFrameworkCore;

namespace EgweneService.Data.Local.Entities;

[Index(nameof(ObjectId), IsUnique = true)]
public class Character
{
    public int CharacterId { get; set; }
    
    public int ObjectId { get; set; }
    public string Name { get; set; }
    
    public Server Server { get; set; }
    
    public ICollection<QuestPoint> QuestPoints { get; set; }
}