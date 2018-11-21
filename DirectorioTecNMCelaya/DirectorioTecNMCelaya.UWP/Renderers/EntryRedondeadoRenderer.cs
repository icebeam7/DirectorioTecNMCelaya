using DirectorioTecNMCelaya.Controles;
using DirectorioTecNMCelaya.UWP.Renderers;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(EntryRedondeado), typeof(EntryRedondeadoRenderer))]
namespace DirectorioTecNMCelaya.UWP.Renderers
{
    public class EntryRedondeadoRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var style = (Windows.UI.Xaml.Style)App.Current.Resources["StyleRoundedTextBox"];
            Control.Style = style;
        }
    }
}
