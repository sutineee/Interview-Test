using Interview_Test.Models;
using Interview_Test.Repositories;
using Interview_Test.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Interview_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet("GetUserById/{id}")]
    public ActionResult GetUserById(string id)
    {
        var data = _userRepository.GetUserById(id);
        if (data == null)
        {
            return NotFound();
        }

        return Ok(data);
    }

    [HttpPost("CreateUsers")]
    public ActionResult GetUserById()
    {
        var effectrow = _userRepository.CreateUsers();
        return Ok(effectrow);
    }

    [HttpPost("CreateUser")]
    public ActionResult GetUserById(UserModel user)
    {
        var effectrow = _userRepository.CreateUser(user);
        return Ok(effectrow);
    }
}