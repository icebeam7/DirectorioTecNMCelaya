using System;
using System.Linq;

using Android.Widget;
using DirectorioTecNMCelaya.Efectos;
using DirectorioTecNMCelaya.Droid.Efectos;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("DirectorioTecNMCelaya")]
[assembly: ExportEffect(typeof(EfectoSombraLabel), "EfectoSombraLabel")]
namespace DirectorioTecNMCelaya.Droid.Efectos
{
    public class EfectoSombraLabel : PlatformEffect
    {
        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }

        protected override void OnAttached()
        {
            try
            {
                var control = Control as TextView;
                var efecto = (EfectoSombra)Element.Effects.FirstOrDefault(e => e is EfectoSombra);

                if (efecto != null)
                {
                    Android.Graphics.Color color = efecto.Color.ToAndroid();
                    control.SetShadowLayer(efecto.Radio, efecto.X, efecto.Y, color);
                }
            }
            catch (Exception ex) // Error al asignar la propiedad
            {
            }
        }
    }
}