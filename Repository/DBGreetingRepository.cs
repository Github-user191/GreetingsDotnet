using GreetingsDotnet.Data;
using GreetingsDotnet.Entity;
using GreetingsDotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace GreetingsDotnet.Repository;

public class DBGreetingRepository : IGreetingRepository {

    private readonly ApplicationDbContext _context;


    public DBGreetingRepository(ApplicationDbContext context) {
        _context = context;
    }

    public async Task<IEnumerable<GreetingModel>> GetAllGreetingsAsync() {
        
        var greetings =  await _context.Set<GreetingEntity>().ToListAsync();

        return greetings.Select(x => new GreetingModel
        {
            Id = x.Id,
            Language = x.Language,
            Greeting = x.Greeting
        });
    }
}