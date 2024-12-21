using GreetingsDotnet.Entity;
using GreetingsDotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace GreetingsDotnet.Data; 


public class ApplicationDbContext : DbContext {
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<GreetingEntity> Greetings { get; set; }

    
    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        
        builder.Entity<GreetingEntity>().HasData(
            new GreetingEntity { Id = 1, Language = "English", Greeting = "Hello" },
            new GreetingEntity { Id = 2, Language = "Spanish", Greeting = "Hola" },
            new GreetingEntity { Id = 3, Language = "French", Greeting = "Bonjour" },
            new GreetingEntity { Id = 4, Language = "German", Greeting = "Hallo" },
            new GreetingEntity { Id = 5, Language = "Italian", Greeting = "Ciao" },
            new GreetingEntity { Id = 6, Language = "Japanese", Greeting = "こんにちは" },
            new GreetingEntity { Id = 7, Language = "Chinese", Greeting = "你好" },
            new GreetingEntity { Id = 8, Language = "Hindi", Greeting = "नमस्ते" },
            new GreetingEntity { Id = 9, Language = "Russian", Greeting = "Привет" },
            new GreetingEntity { Id = 10, Language = "Portuguese", Greeting = "Olá" },
            new GreetingEntity { Id = 11, Language = "Arabic", Greeting = "أهلاً" },
            new GreetingEntity { Id = 12, Language = "Korean", Greeting = "안녕하세요" },
            new GreetingEntity { Id = 13, Language = "Dutch", Greeting = "Hallo" },
            new GreetingEntity { Id = 14, Language = "Swedish", Greeting = "Hej" },
            new GreetingEntity { Id = 15, Language = "Turkish", Greeting = "Merhaba" }
        );
    }

}