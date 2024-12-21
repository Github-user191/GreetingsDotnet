using GreetingsDotnet.Repository;
using Microsoft.AspNetCore.Mvc;

namespace GreetingsDotnet.Controllers;

[ApiController]
public class GreetingsController : ControllerBase {

    private readonly IGreetingRepository _greetingRepository;

    public GreetingsController(IGreetingRepository greetingRepository) {
        _greetingRepository = greetingRepository;
    }

    [HttpGet("api/[controller]")]
    public async Task<ActionResult> GetAll() {
        var greetings = await _greetingRepository.GetAllGreetingsAsync();
        return Ok(greetings);
    }
    
    [HttpGet("/")]
    public async Task<ActionResult> GetAllRoot() {
        var greetings = await _greetingRepository.GetAllGreetingsAsync();
        return Ok(greetings);
    }
    
    
}