using System.ComponentModel.DataAnnotations;

namespace GreetingsDotnet.Entity;

public class GreetingEntity {
    
    [Key]
    public long Id { get; set; }
    public string Language { get; set; }
    public string Greeting { get; set; }
}