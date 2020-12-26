using vtFrontend.GUI.ViewModels.Base;

namespace vtFrontend.GUI.ViewModels
{
    public class MainViewModel : BaseVewModel
    {
        private string _vtKey;

        public string VTKey
        {
            get => _vtKey;

            set
            {
                _vtKey = value;

                OnPropertyChanged();
            }
        }
    }
}