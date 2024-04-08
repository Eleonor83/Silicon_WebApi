using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CoursesController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetALl(int id)
    {
        return Ok();
    }
}
