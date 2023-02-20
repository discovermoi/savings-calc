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

    [HttpPost]
    public IActionResult Create(TicModel ticModel)
    {
        TicService.Add(ticModel);
        return CreatedAtAction(nameof(Get), new { id = ticModel.borrowingAmount }, ticModel);
        // var client = new HttpClient();
        // Console.WriteLine("Making the Post call");
        // var request = new HttpRequestMessage(HttpMethod.Post, "https://api.stage.tictoc.ai/product/v1.0/calculator/getloancomparison");
        // request.Headers.Add("Authorization", "Basic Nm1rcGs1ZWd1Z2UycjFtZWkwOHEwZDV1cjI6MTZzOTllcTMxZW5vNGE4MTc0cjl2cDlvZW1jbXMwMmVnbDNoYTNjazc5NHQ2azBqazNlbQ==");
        // var content = new StringContent("{\n    \"Merchant\": \"TIC\",\n    \"Lender\": \"BEN\",\n    \"RateType\": \"VAR\",\n    \"RepaymentType\": \"PI\",\n    \"PropertyUsage\": \"INV\",\n    \"CustomerRate\": 5.0,\n    \"LoanTerm\": 20,\n    \"BorrowingAmount\": 200000,\n    \"RateTerm\": null\n}", null, "application/json");
        // request.Content = content;
        // var response = await client.SendAsync(request);
        // response.EnsureSuccessStatusCode();
        // Console.WriteLine("Here is the Response ");
        // Console.WriteLine(await response.Content.ReadAsStringAsync());
        // return await response.Content.ReadAsStringAsync();
    }

    private object Get()
    {
        throw new NotImplementedException();
    }
}


