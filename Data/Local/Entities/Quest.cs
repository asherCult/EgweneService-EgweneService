namespace EgweneService.Data.Local.Entities;

public class Quest
{
    public int QuestId { get; set; }
    public string Name { get; set; }
    
    public ICollection<QuestPoint> Points { get; set; }
}