using SavingsCalculator.Models;

namespace SavingsCalculator.Services;

public static class TicService
{
    static List<TicRequestModel> TicRequestModels { get; }
    static TicService()
    {
        TicRequestModels = new List<TicRequestModel>
        {
            new TicRequestModel { Merchant = "TIC", Lender = "BEN", RateType = "VAR", RepaymentType= "PI", PropertyUsage= "INV", CustomerRate = 0.0429, LoanTerm = 20, BorrowingAmount = 600000, RateTerm = null },
        };
    }

    public static List<TicRequestModel> GetAll() => TicRequestModels;

    public static TicRequestModel? Get(int id) => TicRequestModels.FirstOrDefault(p => p.BorrowingAmount == id);

    public static void Add(TicRequestModel TicRequestModel)
    {
        TicRequestModels.Add(TicRequestModel);
    }

}