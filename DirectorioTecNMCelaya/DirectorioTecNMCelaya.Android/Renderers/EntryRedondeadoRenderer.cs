using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;

using DirectorioTecNMCelaya.Controles;
using DirectorioTecNMCelaya.Droid.Renderers;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryRedondeado), typeof(EntryRedondeadoRenderer))]
namespace DirectorioTecNMCelaya.Droid.Renderers
{
    public class EntryRedondeadoRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                var view = (EntryRedondeado)Element;

                var gradient = new GradientDrawable();
                gradient.SetShape(ShapeType.Rectangle);
                gradient.SetColor(view.BackgroundColor.ToAndroid());
                gradient.SetStroke(view.BorderWidth, view.BorderColor.ToAndroid());
                gradient.SetCornerRadius(DpToPixels(Context, Convert.ToSingle(view.CornerRadius)));
                Control.SetBackground(gradient);

                Control.SetPadding(
                    (int)DpToPixels(Context, Convert.ToSingle(12)), Control.PaddingTop,
                    (int)DpToPixels(Context, Convert.ToSingle(12)), Control.PaddingBottom);
            }
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }

        public EntryRedondeadoRenderer(Context context) : base(context)
        {

        }
    }
}