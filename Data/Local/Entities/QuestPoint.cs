namespace EgweneService.Data.Local.Entities;

public class QuestPoint
{
    public int QuestPointId { get; set; }
    
    public string AceString { get; set; }
    public string Name { get; set; }
    public bool Complete { get; set; }
    
    public Quest Quest { get; set; }
    public ICollection<Character> Characters { get; set; }
}