using System.Windows;
using System.Windows.Controls;

using vtFrontend.GUI.ViewModels;

namespace vtFrontend.GUI
{
    public partial class MainWindow : Window
    {
        private MainViewModel Vm => (MainViewModel) DataContext;
        
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        private void Form_OnTextChanged(object sender, TextChangedEventArgs e) => Vm.ValidateForm();

        private void btnResetFields_OnClick(object sender, RoutedEventArgs e) => Vm.ResetFields();

        private void btnExecute_OnClick(object sender, RoutedEventArgs e) => Vm.ExecuteApi();
    }
}