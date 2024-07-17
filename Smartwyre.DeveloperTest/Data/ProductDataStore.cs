using Smartwyre.DeveloperTest.Types;
using System;

namespace Smartwyre.DeveloperTest.Data;

public class ProductDataStore
{
    public Product GetProduct(string productIdentifier)
    {
        // Access database to retrieve account, code removed for brevity 
        return new Product
        {
            Id = new Random().Next(1, 101),
            Identifier = productIdentifier,
            Price = Math.Round((decimal)(new Random().NextDouble() * 500.0), 2),
            Uom = "kilogram",
            SupportedIncentives = 0
        };
    }
}
