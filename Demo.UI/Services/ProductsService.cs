using Demo.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Demo.UI.Services
{
    public class ProductsService : IProductsService
    {
        private readonly HttpClient httpClient;

        public ProductsService(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }
        public async Task<IEnumerable<Product>> getProducts()
        {
            //Should probably be inside a try catch. 
            return await httpClient.GetFromJsonAsync<Product[]>("api/product/getProducts");
            
        }
    }
}
