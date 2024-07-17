using Smartwyre.DeveloperTest.Types;
using System;

namespace Smartwyre.DeveloperTest.Data;

public class RebateDataStore
{
    public Rebate GetRebate(string rebateIdentifier, int incentiveType)
    {
        // Access database to retrieve account, made random for brevity
        return new Rebate { 
            Identifier = rebateIdentifier,
            Incentive = (IncentiveType)incentiveType,
            Amount = Math.Round((decimal)(new Random().NextDouble() * 500.0),2),
            Percentage = (decimal)(new Random().NextDouble() * 20.0)
        };
    }

    public void StoreCalculationResult(Rebate account, decimal rebateAmount)
    {
        // Update account in database, code removed for brevity
    }
}
