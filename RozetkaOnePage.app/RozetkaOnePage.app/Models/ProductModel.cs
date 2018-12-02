using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace RozetkaOnePage.app.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        private ProductCategory _productCategory;
        public ProductCategory ProductCategorySetter
        {
            set { _productCategory = value; }
        }
        public string ProductCategoryGetter
        {
            get { return _productCategory.GetDescription(); }
        }
        private ProductLabel _productLabel;
        public ProductLabel ProductLabelSetter
        {
            set { _productLabel = value; }
        }
        public string ProductLabelGetter
        {
            get { return _productLabel.GetDescription(); }
        }
        public float Price { get; set; }
        public float PreviousPrice { get; set; }
        public ImageSource Image { get; set; }
        public ProductRating ProductRating { get; set; }
        public List<string> Feedback { get; set; }
    }
}
