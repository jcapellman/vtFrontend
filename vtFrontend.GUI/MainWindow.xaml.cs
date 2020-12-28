using System.Windows;
using System.Windows.Controls;

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

        private void Form_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ((MainViewModel) DataContext).ValidateForm();
        }
    }
}