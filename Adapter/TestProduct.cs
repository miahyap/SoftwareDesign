using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class TestProduct : IProduct
    {
        decimal Cost;
        decimal Dimension;
        int Id;
        String Name;

        public TestProduct(decimal cost, decimal dimension, int id, String name) 
        {
            this.Cost = cost;
            this.Id = id;
            this.Dimension = dimension;
            this.Name = name;       
        }
        public decimal GetCost()
        {
            return this.Cost;
        }

        public decimal GetDimension()
        {
            return this.Dimension;
        }

        public int GetId()
        {
            return this.Id;
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
