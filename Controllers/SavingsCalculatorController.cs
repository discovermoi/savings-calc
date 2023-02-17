using Microsoft.AspNetCore.Mvc;

namespace savings_calc.Controllers;


[ApiController]
[Route("[controller]")]
public class SavingsCalculatorController : ControllerBase
{

static HttpClient client = new HttpClient();

[HttpPost]
static async Task<Uri> RetrieveSavingsInformation (SavingsCalculator savings)
        {
            try
            {
                // Create a new product
                SavingsCalculator savings1 = new SavingsCalculator
                {
                   merchant = "TIC", 
                   lender = "BEN", 
                   rateType = "VAR", 
                   repaymentType = "PI", 
                   propertyUsage = "INV", 
                   customerRate = 0.0429,
                   loanTerm = 20, 
                   borrowingAmount = 600000, 
                   rateTerm = null
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

            HttpResponseMessage response = await client.PostAsJsonAsync(
                "api.stage.tictoc.ai/product/v1.0/calculator/getloancomparison", savings);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }
}


