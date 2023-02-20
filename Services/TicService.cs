using savings_calc.Models;

namespace savings_calc.Services;

public static class TicService
{
    static List<TicModel> TicModels { get; }
    static TicService()
    {
        TicModels = new List<TicModel>
        {
            new TicModel { merchant = "TIC", lender = "BEN", rateType = "VAR", repaymentType= "PI", propertyUsage= "INV", customerRate = 0.0429, loanTerm = 20, borrowingAmount = 600000, rateTerm = null },
            new TicModel { merchant = "TIC", lender = "BEN", rateType = "VAR", repaymentType= "PI", propertyUsage= "INV", customerRate = 0.0729, loanTerm = 20, borrowingAmount = 500000, rateTerm = null }
        };
    }

    public static List<TicModel> GetAll() => TicModels;

    public static TicModel? Get(int id) => TicModels.FirstOrDefault(p => p.borrowingAmount == id);

    public static void Add(TicModel TicModel)
    {
        TicModels.Add(TicModel);
    }

    public static void Delete(int id)
    {
        var TicModel = Get(id);
        if(TicModel is null)
            return;

        TicModels.Remove(TicModel);
    }

    public static void Update(TicModel TicModel)
    {
        var index = TicModels.FindIndex(p => p.borrowingAmount == TicModel.borrowingAmount);
        if(index == -1)
            return;

        TicModels[index] = TicModel;
    }
}