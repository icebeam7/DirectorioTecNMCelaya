using DirectorioTecNMCelaya.Helpers;
using DirectorioTecNMCelaya.Servicios;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DirectorioTecNMCelaya.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaAcercaDe : ContentPage
	{
		public PaginaAcercaDe ()
		{
			InitializeComponent ();

            CrearTapGestureCorreo();
		}

        void CrearTapGestureCorreo()
        {
            var tgrCorreo = new TapGestureRecognizer();

            tgrCorreo.Tapped += (s, e) =>
            {
                ServicioCorreo.EnviarCorreo(
                    Constantes.CorreoContactoApp, Constantes.AsuntoApp, "¡Hola! Me llamo ... ");
            };

            lblLuis.GestureRecognizers.Add(tgrCorreo);
        }
    }
}