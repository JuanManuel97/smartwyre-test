using Smartwyre.DeveloperTest.Services;
using Smartwyre.DeveloperTest.Types;
using System;

namespace Smartwyre.DeveloperTest.Runner;

class Program
{
    static void Main(string[] args)
    {
        IRebateService service = new RebateService();

        Console.Write("Enter Rebate Identifier: ");
        var rebateIdentifier = Console.ReadLine();

        Console.Write("Enter Product Identifier: ");
        var productIdentifier = Console.ReadLine();

        Console.Write("Enter Volume: ");
        decimal volume = decimal.Parse(Console.ReadLine());

        CalculateRebateRequest request = new CalculateRebateRequest { RebateIdentifier = rebateIdentifier, ProductIdentifier = productIdentifier, Volume = volume };

        CalculateRebateResult result = service.Calculate(request);
    }
}
