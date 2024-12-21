using GreetingsDotnet.Models;

namespace GreetingsDotnet.Repository;

public interface IGreetingRepository {
    Task<IEnumerable<GreetingModel>> GetAllGreetingsAsync();
}