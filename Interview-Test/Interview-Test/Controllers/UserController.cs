using Interview_Test.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Interview_Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("GetUserById/{id}")]
    public ActionResult GetUserById(string id)
    {
        //Todo: Implement this method
        return Ok(Data.Users);
    }
}