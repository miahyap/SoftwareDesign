using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryExampleApp
{
    interface IProduct
    {
        String getProductType();
        int getCost();
    }
}
