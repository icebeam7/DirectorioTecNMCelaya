using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DirectorioTecNMCelaya.Modelos;
using DirectorioTecNMCelaya.Servicios;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DirectorioTecNMCelaya
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Paginas.PaginaInicio());
        }

        protected override async void OnStart()
        {
            base.OnStart();
        }
    }
}
