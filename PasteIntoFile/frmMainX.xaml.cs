using System;
using System.Windows;

namespace PasteIntoFile
{
    /// <summary>
    /// Interaction logic for frmMainX.xaml
    /// </summary>
    public partial class frmMainX : Window
    {
        public frmMainX()
        {
            InitializeComponent();
        }

        private void lblHelp_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
            Environment.Exit(0);
        }
    }
}
