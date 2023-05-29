using Microsoft.AspNetCore.Mvc;

namespace user.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    public UserController() { }

    [HttpGet]
    public IEnumerable<User> Get()
    {
        return Enumerable.Range(1, 5)
            .Select(index => new User
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = "asdf"
            })
            .ToArray();
    }
}
