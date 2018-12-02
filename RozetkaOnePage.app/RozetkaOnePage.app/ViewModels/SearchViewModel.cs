using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using RozetkaOnePage.app.Models;
using RozetkaOnePage.app.Services;

namespace RozetkaOnePage.app.ViewModels
{
    class SearchViewModel : ViewModelBase
    {
        IProductService _productService;

        public SearchViewModel(INavigationService navigationService, IProductService productService) : base(navigationService)
        {
            _productService = productService;
        }

        #region — Public properties —

        private List<ProductModel> _productsFound;
        public List<ProductModel> ProductsFound
        {
            get { return _productsFound; }
            set
            {
                SetProperty(ref _productsFound, value);
            }
        }

        private string _searchStr;
        public string SearchStr
        {
            get { return _searchStr; }
            set
            {
                ProductsFound = _productService.GetProductsByName(value);
                SetProperty(ref _searchStr, value);
            }
        }

        #endregion
    }
}
