using System.Windows;

using vtFrontend.GUI.ViewModels;

namespace vtFrontend.GUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}