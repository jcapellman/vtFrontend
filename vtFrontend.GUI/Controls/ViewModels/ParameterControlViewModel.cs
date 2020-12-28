using vtFrontend.GUI.ViewModels.Base;
using vtFrontend.lib.Parameters.Base;

namespace vtFrontend.GUI.Controls.ViewModels
{
    public class ParameterControlViewModel : BaseVewModel
    {
        private BaseParameter _parameter;

        public BaseParameter Parameter
        {
            get => _parameter;

            set
            {
                _parameter = value;
                
                OnPropertyChanged();
            }
        }
    }
}