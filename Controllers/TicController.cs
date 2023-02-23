using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SavingsCalculator.Models;
using SavingsCalculator.Services;

namespace SavingsCalculator.Controllers;

public class TicController : ControllerBase
{
    private readonly ILogger<TicController> _logger;

    public TicController(ILogger<TicController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IEnumerable<TicResponseModel> PostTicData([FromBody] TicRequestModel ticRequestModel)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage(HttpMethod.Post, "https://api.stage.tictoc.ai/product/v1.0/calculator/getloancomparison");
        request.Headers.Add("Authorization", "Basic Nm1rcGs1ZWd1Z2UycjFtZWkwOHEwZDV1cjI6MTZzOTllcTMxZW5vNGE4MTc0cjl2cDlvZW1jbXMwMmVnbDNoYTNjazc5NHQ2azBqazNlbQ==");
        var content = new StringContent("{\n    \"Merchant = \"TIC\",\n    \"Lender = \"BEN\",\n    \"RateType = \"VAR\",\n    \"RepaymentType = \"PI\",\n    \"PropertyUsage = \"INV\",\n    \"CustomerRate = 5.0,\n    \"LoanTerm = 20,\n    \"BorrowingAmount = 200000,\n    \"RateTerm = null\n}", null, "application/json");
        request.Content = content;
        var response = client.SendAsync(request);
        Console.WriteLine("Tic Response ", response.Result.Content.ReadAsStringAsync());
        return Enumerable.Range(1, 5).Select(index => new TicResponseModel
        {
            MonthlyRepaymentDifference = "638.635755729224",
            PayPeriodDifference = "49.0",
            TotalSaved = "30501.889948729",
            RequestId = "9a5a4",
            Messages = new[] { "here", "there", "mine" }
        });

    }

}


