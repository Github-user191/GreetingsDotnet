using GreetingsDotnet.Models;

namespace GreetingsDotnet.Repository;

public class InMemoryGreetingRepository : IGreetingRepository
{
    private readonly List<GreetingModel> _inMemoryGreetings = new()
    {
        new GreetingModel { Id = 1, Language = "English", Greeting = "Hello" },
        new GreetingModel { Id = 2, Language = "Spanish", Greeting = "Hola" },
        new GreetingModel { Id = 3, Language = "French", Greeting = "Bonjour" },
        new GreetingModel { Id = 4, Language = "German", Greeting = "Hallo" },
        new GreetingModel { Id = 5, Language = "Italian", Greeting = "Ciao" },
        new GreetingModel { Id = 6, Language = "Japanese", Greeting = "こんにちは" },
        new GreetingModel { Id = 7, Language = "Chinese", Greeting = "你好" },
        new GreetingModel { Id = 8, Language = "Hindi", Greeting = "नमस्ते" },
        new GreetingModel { Id = 9, Language = "Russian", Greeting = "Привет" },
        new GreetingModel { Id = 10, Language = "Portuguese", Greeting = "Olá" },
        new GreetingModel { Id = 11, Language = "Arabic", Greeting = "أهلاً" },
        new GreetingModel { Id = 12, Language = "Korean", Greeting = "안녕하세요" },
        new GreetingModel { Id = 13, Language = "Dutch", Greeting = "Hallo" },
        new GreetingModel { Id = 14, Language = "Swedish", Greeting = "Hej" },
        new GreetingModel { Id = 15, Language = "Turkish", Greeting = "Merhaba" }
    };


    public Task<IEnumerable<GreetingModel>> GetAllGreetingsAsync() {
        return Task.FromResult<IEnumerable<GreetingModel>>(_inMemoryGreetings);
    }
}
