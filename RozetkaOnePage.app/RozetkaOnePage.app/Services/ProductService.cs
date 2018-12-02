using RozetkaOnePage.app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RozetkaOnePage.app.Services
{
    public class ProductService : IProductService
    {
        private List<ProductModel> _products;

        public ProductService()
        {
            _products = new List<ProductModel>
            {
                new ProductModel
                {
                    Name = "Ноутбук Lenovo IdeaPad 330-151KBR",
                    ProductCategorySetter = ProductCategory.Laptops,
                    ProductLabelSetter = ProductLabel.TopSales,
                    Feedback = new List<string>{"","","","","","","",""},
                    Image = "notebook",
                    Price = 17499,
                    PreviousPrice = 18999
                },
                 new ProductModel
                {
                    Name = "Samsung Galaxy J6 2/32GB Black (SM-J600FZKDSEK)",
                    ProductCategorySetter = ProductCategory.CellРhones,
                    ProductLabelSetter = ProductLabel.SuperPrice,
                    Feedback = new List<string>{"","","","","","","","","","","","","","","",
                        "","","","","","","","","","","","","","","","","","","","","","","",""},
                    Image = "smBlack",
                    Price = 5499,
                    PreviousPrice = 5199
                },
                 new ProductModel
                {
                    Name = "Планшет Asus ZenPad 3S 10 4/64GB",
                    ProductCategorySetter = ProductCategory.Tablets,
                    ProductLabelSetter = ProductLabel.TopSales,
                    Feedback = new List<string>{"","","","","","","","","","","","","","","","","","","","","","","",""},
                    Image = "asus",
                    Price = 9499,
                    PreviousPrice = 8999
                },              
            };
        }

        public List<ProductModel> GetProducts()
        {
            return _products;
        }

        public ProductModel GetProductById(Guid id)
        {
            return _products.Find(z => z.Id == id);
        }

        public List<ProductModel> GetProductsByName(string name)
        {
            return _products.FindAll(p => p.Name.ToLowerInvariant().StartsWith(name.ToLowerInvariant()) && (name != ""));
        }
    }
}
