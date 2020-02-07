using System.Windows;

namespace Databinding_D_notification
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Title = "INotifyPropertyChanged";
            wnd.Show();
        }
    }
}
