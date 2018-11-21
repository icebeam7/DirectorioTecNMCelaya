using System;
using System.Linq;

using CoreGraphics;
using DirectorioTecNMCelaya.Efectos;
using DirectorioTecNMCelaya.iOS.Efectos;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("DirectorioTecNMCelaya")]
[assembly: ExportEffect(typeof(EfectoSombraLabel), "EfectoSombraLabel")]
namespace DirectorioTecNMCelaya.iOS.Efectos
{
    public class EfectoSombraLabel : PlatformEffect
    {
        protected override void OnDetached()
        {
        }

        protected override void OnAttached()
        {
            try
            {
                var efecto = (EfectoSombra)Element.Effects.FirstOrDefault(e => e is EfectoSombra);

                if (efecto != null)
                {
                    Control.Layer.CornerRadius = efecto.Radio;
                    Control.Layer.ShadowColor = efecto.Color.ToCGColor();
                    Control.Layer.ShadowOffset = new CGSize(efecto.X, efecto.Y);
                    Control.Layer.ShadowOpacity = 1.0f;
                }
            }
            catch (Exception ex) // Error al asignar la propiedad
            {
            }
        }
    }
}