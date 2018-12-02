using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RozetkaOnePage.app.ViewModels
{
    class MasterDetailViewModel
    {
        INavigationService _navigationService;
        public DelegateCommand<string> OnNavigationCommand { get; set; }

        public MasterDetailViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            OnNavigationCommand = new DelegateCommand<string>(NavigateAsync);
        }

        async void NavigateAsync(string page)
        {
            await _navigationService.NavigateAsync(new Uri(page, UriKind.Relative));
        }

    }
}
