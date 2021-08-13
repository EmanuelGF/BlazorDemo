using Demo.DataModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            return await httpClient.GetJsonAsync<Product[]>("api/product/getProducts");
        }
    }
}
