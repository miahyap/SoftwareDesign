using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class ComputerLeaf : IComputerComponent
    {
        decimal price;
        String name;
        public ComputerLeaf(int price, String name) 
        {
            this.price = price;
            this.name = name;
        }

        public void Add(IComputerComponent c)
        {
            throw new NotImplementedException();
        }

        public int GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public decimal GetPrice()
        {
            return price;
        }

        public void Remove(IComputerComponent c)
        {
            throw new NotImplementedException();
        }
    }
}
