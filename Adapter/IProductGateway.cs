using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IProductGateway
    {
        // delete a product from the shop
        IProduct Delete(int id);

        // add a new product to the shop
        void Insert(IProduct prod);

        // commit changes to long-term storage
        void Save();

        // get all of the products in the shop
        IEnumerable<IProduct> SelectAll();

        // get a product according to its unique identifier
        IProduct SelectById(int id);

        // update the information about an existing product
        void Update(IProduct prod);
    }
}
