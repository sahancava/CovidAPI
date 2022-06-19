using Microsoft.AspNetCore.Mvc;

namespace CovidAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CovidAPIController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CovidAPIController> _logger;

    public CovidAPIController(ILogger<CovidAPIController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCovidAPI")]
    public IActionResult Get()
    {
        return Ok("XYZ");
    }
}

