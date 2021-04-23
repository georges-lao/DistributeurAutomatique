using DistributeurAutomatique.DataAccess;
using DistributeurAutomatique.viewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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
            var reader = new ServiceReader();
            var viewModel = new BeveragesViewModel(reader);
            Application.Current.MainWindow = new MainWindow(viewModel);
            Application.Current.MainWindow.Show();
        }
    }
}
