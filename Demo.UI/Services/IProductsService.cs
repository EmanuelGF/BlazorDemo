using Demo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.UI.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> getProducts();
    }
}
