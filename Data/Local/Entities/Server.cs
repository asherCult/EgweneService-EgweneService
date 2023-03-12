using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EgweneService.Data.Local.Entities;

[Index(nameof(Name), IsUnique = true)]
public class Server
{
    
    public int ServerId { get; set; }
    
    [StringLength(120)]
    public string? Name { get; set; }
    
    public ICollection<Character> Characters { get; set; }
    
    
}