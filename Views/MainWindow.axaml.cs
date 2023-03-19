using Avalonia.Controls;
using CityEventLab3.ViewModels;

namespace CityEventLab3.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
