using System.Windows;

namespace PasteIntoFile
{
    public partial class ContainerApp : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow = new SaveDialog();
            MainWindow.Show();
            MainWindow.Activate();
            Exit += OnApplicationExit;
        }

        private void OnApplicationExit(object sender, ExitEventArgs e)
        {
            // Clean up if necessasry
        }
    }
}
