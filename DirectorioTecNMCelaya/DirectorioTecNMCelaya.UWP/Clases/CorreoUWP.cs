using System;
using Windows.ApplicationModel.Email;
using DirectorioTecNMCelaya.Interfaces;
using DirectorioTecNMCelaya.UWP.Clases;

[assembly: Xamarin.Forms.Dependency(typeof(CorreoUWP))]
namespace DirectorioTecNMCelaya.UWP.Clases
{
    public class CorreoUWP : ICorreo
    {
        public async void CrearCorreo(string direccion, string asunto, string mensaje)
        {
            EmailMessage email = new EmailMessage();

            email.To.Add(new EmailRecipient(direccion));
            email.Subject = asunto;
            email.Body = mensaje;

            await EmailManager.ShowComposeNewEmailAsync(email);
        }
    }
}
