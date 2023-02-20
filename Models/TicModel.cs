namespace savings_calc.Models;

public class TicModel
{
    public int borrowingAmount {get; set; }
    
    public double customerRate {get; set; }

    public string? merchant {get; set; }

    public string? lender {get; set; }

    public string? rateType {get; set; }

    public string? repaymentType {get; set; }

    public string? propertyUsage {get; set; }

    public int loanTerm {get; set; }

    public string? rateTerm {get; set; }

}
