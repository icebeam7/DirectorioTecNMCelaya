using Android.App;
using Android.Content.PM;
using Android.OS;

namespace DirectorioTecNMCelaya.Droid
{
    [Activity(Label = "DirectorioTecNMCelaya", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        internal static MainActivity Instance { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Instance = this;
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            try
            {
                LoadApplication(new App());
            }
            catch(Java.Lang.Exception ex)
            {

            }
            catch(System.Exception ex)
            {

            }
        }
    }
}