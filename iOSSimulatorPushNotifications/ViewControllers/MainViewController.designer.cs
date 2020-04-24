using Foundation;
using System.CodeDom.Compiler;

namespace iOSSimulatorPushNotifications
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        AppKit.NSTextField BundleIdTextField { get; set; }

        [Outlet]
        AppKit.NSTextFieldCell PayloadTextField { get; set; }

        [Outlet]
        AppKit.NSButton SendNotification { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BundleIdTextField != null) {
                BundleIdTextField.Dispose ();
                BundleIdTextField = null;
            }

            if (PayloadTextField != null) {
                PayloadTextField.Dispose ();
                PayloadTextField = null;
            }

            if (SendNotification != null) {
                SendNotification.Dispose ();
                SendNotification = null;
            }
        }
    }
}
