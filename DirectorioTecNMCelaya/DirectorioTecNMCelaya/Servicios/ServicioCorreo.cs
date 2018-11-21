using DirectorioTecNMCelaya.Interfaces;

using Xamarin.Forms;

namespace DirectorioTecNMCelaya.Servicios
{
    public static class ServicioCorreo
    {
        public static void EnviarCorreo(string direccion, string asunto, string mensaje)
        {
            var correo = DependencyService.Get<ICorreo>();
            correo.CrearCorreo(direccion, asunto, mensaje);
        }
    }
}
