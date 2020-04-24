using System;
using System.Diagnostics;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using ReactiveUI;

namespace iOSSimulatorPushNotifications
{
    public partial class MainViewController : ReactiveViewController<MainViewModel>
    {
        public MainViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            ViewModel = new MainViewModel ();

            this.WhenActivated (d => {
                Observable.FromEventPattern (h => SendNotification.Activated += h, h => SendNotification.Activated -= h)
                          .Subscribe (_ => DoSendNotification ())
                          .DisposeWith (d);
            });
        }

        void DoSendNotification ()
        {
            var tmpFile = TemporaryFilesHelper.CreateTempFile ();
            TemporaryFilesHelper.UpdateTempFile (tmpFile, PayloadTextField.StringValue);

            var shutdownCmdLine = $"simctl push booted {BundleIdTextField.StringValue} {tmpFile}";
            var shutdownProcess = Process.Start ("xcrun", shutdownCmdLine);

            shutdownProcess.WaitForExit ();

            TemporaryFilesHelper.DeleteTempFile (tmpFile);
        }
    }
}
