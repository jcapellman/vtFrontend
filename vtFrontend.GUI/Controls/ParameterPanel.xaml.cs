using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using vtFrontend.GUI.Controls.ViewModels;
using vtFrontend.lib.Parameters.Base;

namespace vtFrontend.GUI.Controls
{
    public partial class ParameterPanel : UserControl
    {
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register(nameof(Parameters), typeof(List<BaseParameter>), typeof(ParameterPanel),
                new FrameworkPropertyMetadata(null, new PropertyChangedCallback(PropertyChangedCallback)));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //
        }

        public List<BaseParameter> Parameters
        {
            set => SetValue(ItemSourceProperty, value);

            get => (List<BaseParameter>)GetValue(ItemSourceProperty);
        }


        public event EventHandler<BaseParameter> OnParameterValueChanged;

        
        private void InitializeControls()
        {
            foreach (var parameter in Parameters)
            {
                var cParameter = new ParameterControl();

              //  ((ParameterControlViewModel)cParameter.DataContext).Parameter = parameter;

                cParameter.OnParameterValueChanged += CParameterOnOnParameterValueChanged;

                spParameters.Children.Add(cParameter);
            }
        }

        // TODO: Replace this quick and dirty hack down the road
        private void CParameterOnOnParameterValueChanged(object? sender, BaseParameter e) =>
            OnParameterValueChanged?.Invoke(null, e);

        public ParameterPanel()
        {
            InitializeComponent();
        }
    }
}