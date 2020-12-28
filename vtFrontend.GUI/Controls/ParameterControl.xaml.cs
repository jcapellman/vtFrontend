using System;
using System.Collections.Generic;
using System.Windows.Controls;

using vtFrontend.GUI.Controls.ViewModels;
using vtFrontend.lib.Parameters.Base;

namespace vtFrontend.GUI.Controls
{
    public partial class ParameterControl : UserControl
    {
        
        
        public ParameterControl()
        {
            InitializeComponent();

            DataContext = new ParameterControlViewModel();
        }

        public event EventHandler<BaseParameter> OnParameterValueChanged;
        
        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            OnParameterValueChanged?.Invoke(sender, ((ParameterControlViewModel)DataContext).Parameter);    
        }
    }
}