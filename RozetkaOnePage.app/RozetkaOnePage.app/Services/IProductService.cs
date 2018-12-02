using RozetkaOnePage.app.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RozetkaOnePage.app.Services
{
    public interface IProductService
    {
        List<ProductModel> GetProducts();
        ProductModel GetProductById(Guid id);
        List<ProductModel> GetProductsByName(string name);
    }
}
