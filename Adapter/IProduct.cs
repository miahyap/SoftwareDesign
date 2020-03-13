using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IProduct
    {
        // get the unique product identifier
        int GetId();

        // get the name of the product
        string GetName();

        // get the price of the product
        decimal GetCost();

        // get the weight of the product
        decimal GetDimension();
    }
}
