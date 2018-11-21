using System;
using System.Linq;

using DirectorioTecNMCelaya.Efectos;
using DirectorioTecNMCelaya.UWP.Efectos;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("DirectorioTecNMCelaya")]
[assembly: ExportEffect(typeof(EfectoSombraLabel), "EfectoSombraLabel")]
namespace DirectorioTecNMCelaya.UWP.Efectos
{
    public class EfectoSombraLabel : PlatformEffect
    {
        bool shadowAdded = false;

        protected override void OnDetached()
        {
        }

        protected override void OnAttached()
        {
            try
            {
                if (!shadowAdded)
                {
                    var efecto = (EfectoSombra)Element.Effects.FirstOrDefault(e => e is EfectoSombra);

                    if (efecto != null)
                    {
                        var textBlock = Control as Windows.UI.Xaml.Controls.TextBlock;
                        var shadowLabel = new Label();
                        shadowLabel.Text = textBlock.Text;
                        shadowLabel.FontAttributes = FontAttributes.Bold;
                        shadowLabel.HorizontalOptions = LayoutOptions.Center;
                        shadowLabel.VerticalOptions = LayoutOptions.CenterAndExpand;
                        shadowLabel.FontSize = 20;
                        shadowLabel.TextColor = efecto.Color;
                        shadowLabel.TranslationX = efecto.X;
                        shadowLabel.TranslationY = efecto.Y;

                        ((Grid)Element.Parent).Children.Insert(0, shadowLabel);
                        shadowAdded = true;
                    }
                }
            }
            catch (Exception ex) // Error al asignar la propiedad
            {
            }
        }
    }
}
