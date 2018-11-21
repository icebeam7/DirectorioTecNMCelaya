using System;
using System.Collections.Generic;
using DirectorioTecNMCelaya.Modelos;
using DirectorioTecNMCelaya.Servicios;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DirectorioTecNMCelaya.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaListaContactos : ContentPage
	{
        public List<Contacto> Contactos;

        public PaginaListaContactos ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Contactos = await ServicioContactos.ObtenerContactos();
            lstProfesores.ItemsSource = Contactos;
        }

        private void txtProfesores_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.OldTextValue != null)
            {
                lstProfesores.ItemsSource = ServicioContactos.BuscarContactos(Contactos, txtProfesores.Text);
            }
        }

        private async void btnCorreo_Clicked(object sender, EventArgs e)
        {
            if (lstProfesores.SelectedItem != null)
            {
                var contacto = (Contacto)lstProfesores.SelectedItem;
                ServicioCorreo.EnviarCorreo(contacto.Email, "", "");
            }
            else
            {
                await DisplayAlert("Error", "Debes seleccionar un contacto primero", "Ok");
            }
        }
    }
}