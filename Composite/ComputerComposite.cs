

using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class ComputerComposite : IComputerComponent
    {
        String name;
        List<IComputerComponent> myComponentsList;
        public ComputerComposite(String name) 
        {
            myComponentsList = new List<IComputerComponent>();
            this.name = name;
        }
        
        public decimal GetPrice()
        {
            decimal price = 0;
            foreach (IComputerComponent c in myComponentsList)
            {
                price+= c.GetPrice();
            }
            return price;
        }

        public void Add(IComputerComponent c) 
        {
            myComponentsList.Add(c);
        }

        public void Remove(IComputerComponent c) 
        {
            throw new NotImplementedException();
        }
       
        public int GetChild(int i)
        {
            throw new NotImplementedException();
        }
    }
}
