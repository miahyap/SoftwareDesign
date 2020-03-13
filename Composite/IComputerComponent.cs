using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface IComputerComponent
    {
        decimal GetPrice();
        void Add(IComputerComponent c);

        void Remove(IComputerComponent c);

        int GetChild(int i);
    }
}
