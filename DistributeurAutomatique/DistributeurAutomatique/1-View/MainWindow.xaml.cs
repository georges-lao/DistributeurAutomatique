using DistributeurAutomatique.viewModel;
using System.Windows;

namespace DistributeurAutomatique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BeveragesViewModel viewModel;
        public MainWindow(BeveragesViewModel beverageViewModel)
        {
            InitializeComponent();
            viewModel = beverageViewModel;
            this.DataContext = viewModel;
        }

    }
}
