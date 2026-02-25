using Microsoft.AspNetCore.Mvc;
using UserManagement.Api.Models;

namespace UserManagement.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private static List<User> _users = new();

    [HttpGet]
    public IActionResult GetUsers()
    {
        return Ok(_users);
    }

    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        _users.Add(user);
        return Ok(user);
    }
    [HttpGet("{id}")]
    public IActionResult GetUserById(long id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);

        if (user == null)
            return NotFound();

        return Ok(user);
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteUser(long id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);

        if (user == null)
            return NotFound();

        _users.Remove(user);

        return NoContent();
    }
    [HttpPut("{id}")]
    public IActionResult UpdateUser(long id, User updatedUser)
    {
        var existingUser = _users.FirstOrDefault(u => u.Id == id);

        if (existingUser == null)
            return NotFound();

        existingUser.FirstName = updatedUser.FirstName;
        existingUser.LastName = updatedUser.LastName;
        existingUser.Email = updatedUser.Email;
        existingUser.IsActive = updatedUser.IsActive;

        return Ok(existingUser);
    }
}
