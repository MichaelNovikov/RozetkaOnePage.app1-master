using DLToolkit.Forms.Controls;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using RozetkaOnePage.app.Services;
using RozetkaOnePage.app.ViewModels;
using RozetkaOnePage.app.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace RozetkaOnePage.app
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            FlowListView.Init();

#if DEBUG
            LiveReload.Init();
#endif
            await NavigationService.NavigateAsync(new System.Uri("/MasterDetailView/NavigationPage/MainView", UriKind.Absolute));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MasterDetailView, MasterDetailViewModel>();
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
            containerRegistry.RegisterForNavigation<ProductDetailView, ProductDetailViewModel>();
            containerRegistry.RegisterForNavigation<SearchView, SearchViewModel>();
            containerRegistry.RegisterForNavigation<Page1>();
            containerRegistry.RegisterSingleton<IProductService, ProductService>();
        }
    }
}
