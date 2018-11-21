using Android.Content;

using DirectorioTecNMCelaya.Droid.Clases;
using DirectorioTecNMCelaya.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(CorreoAndroid))]
namespace DirectorioTecNMCelaya.Droid.Clases
{
    public class CorreoAndroid : ICorreo
    {
        public void CrearCorreo(string direccion, string asunto, string mensaje)
        {
            var email = new Intent(Intent.ActionSend);

            email.PutExtra(Intent.ExtraEmail, new string[] { direccion });
            email.PutExtra(Intent.ExtraSubject, asunto);
            email.PutExtra(Intent.ExtraText, mensaje);
            email.SetType("message/rfc822");

            MainActivity.Instance.StartActivity(email);
        }
    }
}