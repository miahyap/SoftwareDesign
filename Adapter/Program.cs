// Adapter pattern for using a Dictionary as a realisation of IProductGateway.
//
// Main Author: Nicholas Sheppard
// Edits: GK
//

using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Adapter...");
            IProduct test = new TestProduct(10, 1000, 1, "first product");
            IProductGateway gateway = new ProductDictionaryAdapter();
            gateway.Insert(test);
            Console.WriteLine("The product with Id 1 is..." + gateway.SelectById(1).GetName()+ " and it costs $ "+ gateway.SelectById(1).GetCost());
            Console.ReadLine();
        }
    }
}
