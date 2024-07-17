using Smartwyre.DeveloperTest.Data;
using Smartwyre.DeveloperTest.Services;
using Smartwyre.DeveloperTest.Types;
using System;
using System.Collections.Generic;

namespace Smartwyre.DeveloperTest.Runner;

class Program
{
    static void Main(string[] args)
    {
        IRebateService service = new RebateService();

        Console.Write("Enter rebate Identifier: ");
        var rebateIdentifier = Console.ReadLine();

        Console.Write("Enter product Identifier: ");
        var productIdentifier = Console.ReadLine();

        Console.Write("Enter request Volume: ");
        decimal volume = decimal.Parse(Console.ReadLine());

        // Initialize data stores and strategies
        var rebateDataStore = new RebateDataStore();
        var productDataStore = new ProductDataStore();

        Console.WriteLine("There are several types of Rebate incentives, select one of the followings:");

        foreach (var incentiveType in Enum.GetValues(typeof(IncentiveType)))
        {
            Console.WriteLine($"Press {(int)incentiveType} if you choose {incentiveType}");
        }

        var incentiveTypeInput = int.Parse(Console.ReadLine());





        /*var rebate = new Rebate
        {
            Incentive = (IncentiveType)incentiveTypeInput,
            Percentage = percentaje,
            Amount = amount
        };*/



        var request = new CalculateRebateRequest { 
            RebateIdentifier = rebateIdentifier, 
            ProductIdentifier = productIdentifier, 
            Volume = volume, 
            IncentiveType = incentiveTypeInput 
        };

        CalculateRebateResult result = service.Calculate(request);

        Console.WriteLine(result.Success);
    }
}
