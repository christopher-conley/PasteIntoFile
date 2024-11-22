using System;
using System.Windows;
using System.Windows.Controls;

namespace PasteIntoFile
{
    /// <summary>
    /// Interaction logic for SaveDialog.xaml
    /// </summary>
    public partial class SaveDialog : Window
    {
        public SaveDialog()
        {
            InitializeComponent();
            this.Closing += OnWindowClosing;

        }

        private void OnWindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Perform any necessary cleanup here
            if (Application.Current != null)
            {
                Application.Current.Shutdown();
            }
        }
        private void lblHelp_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            OnWindowClosing(sender, null);
        }

        private void MenuFile_GotFocus(object sender, RoutedEventArgs e)
        {
            MenuItem fileMenu = (MenuItem) this.FindName("MenuFile");
            fileMenu.FontWeight = FontWeights.Bold;
        }

        private void MenuFile_LostFocus(object sender, RoutedEventArgs e)
        {
            MenuItem fileMenu = (MenuItem) this.FindName("MenuFile");
            fileMenu.FontWeight = FontWeights.Regular;
        }
    }
}
