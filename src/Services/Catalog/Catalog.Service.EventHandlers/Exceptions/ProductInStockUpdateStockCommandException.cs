using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Service.EventHandlers.Exceptions
{
    class ProductInStockUpdateStockCommandException : Exception
    {
        public ProductInStockUpdateStockCommandException(string message) : base(message)
        {

        }
    }
}
