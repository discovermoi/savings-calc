using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using savings_calc.Models;
using savings_calc.Services;

namespace savings_calc.Controllers;


[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
[EnableCors("ReactPolicy")]
public class TicController : ControllerBase
{
    private readonly ILogger<TicController> _logger;

    public TicController(ILogger<TicController> logger)
    {
        _logger = logger;
    }

}


