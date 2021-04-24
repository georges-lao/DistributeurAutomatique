using DistributeurAutomatique.DataAccess;
using DistributeurAutomatique.viewModel;
using System.Windows;

namespace DistributeurAutomatique
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObject();
            Application.Current.MainWindow.Title = "Liste des Boissons";
            Application.Current.MainWindow.Show();
        }

        /// <summary>
        /// set compose object for application
        /// </summary>
        private static void ComposeObject ()
        {
            var reader = new ServiceReader();
            var viewModel = new BeveragesViewModel(reader);
            Application.Current.MainWindow = new MainWindow(viewModel);
        }
    }
}
