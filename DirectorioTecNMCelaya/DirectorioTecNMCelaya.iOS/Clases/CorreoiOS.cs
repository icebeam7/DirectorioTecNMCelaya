using UIKit;
using MessageUI;

using DirectorioTecNMCelaya.Interfaces;
using DirectorioTecNMCelaya.iOS.Clases;

[assembly: Xamarin.Forms.Dependency(typeof(CorreoiOS))]
namespace DirectorioTecNMCelaya.iOS.Clases
{
    public class CorreoiOS : ICorreo
    {
        public void CrearCorreo(string direccion, string asunto, string mensaje)
        {
            var vc = new MFMailComposeViewController();
            vc.MailComposeDelegate = new MFMailComposeViewControllerDelegate();
            vc.SetToRecipients(new string[] { direccion });
            vc.SetSubject(asunto);
            vc.SetMessageBody(mensaje, false);

            vc.Finished += (sender, e) =>
            {
                vc.DismissModalViewController(true);
            };

            UIApplication.SharedApplication.Windows[0].
                RootViewController.PresentViewController(vc, true, null);
        }
    }
}