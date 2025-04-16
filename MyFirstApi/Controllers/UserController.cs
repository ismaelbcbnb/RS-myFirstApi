using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Requests;
using MyFirstApi.Communication.Responses;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById(int id)
    {
        var response = new User()
        {
            Id = id,
            Name = "Ismael Costa",
            Age = 37
        };
        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson()
        {
            Id = 1,
            Name = "Ismael Costa"
        };
        return Created(string.Empty, response);
    }

    [HttpPut]
    [ProducesResponseType(typeof(ResponseUpdatedUserJson), StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdateUserProfileJson request, int id)
    {
        return NoContent();
    }
    
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete( int id)
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<User>()
        {
            new User() { Id = 1, Name = "Ismael Costa", Age = 37 },
            new User() { Id = 2, Name = "George Lucas", Age = 26 },
            new User() { Id = 3, Name = "Camila Marinho", Age = 35 }
        };
        return Ok(response);
    }

    [HttpPut]
    [Route("change-password")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
    {
        return NoContent(); 
    }


}