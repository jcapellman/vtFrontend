using System.Collections.Generic;

using vtFrontend.GUI.ViewModels.Base;
using vtFrontend.lib.APIs.Base;
using vtFrontend.lib.Objects;

namespace vtFrontend.GUI.ViewModels
{
    public class MainViewModel : BaseVewModel
    {
        private SettingsItem _settings;

        public SettingsItem Settings
        {
            get => _settings;

            set
            {
                _settings = value;

                OnPropertyChanged();
            }
        }

        private List<BaseAPI> _apis;

        public List<BaseAPI> Apis
        {
            get => _apis;

            set
            {
                _apis = value;
                
                OnPropertyChanged();
            }
        }

        private BaseAPI _selectedApi;

        public BaseAPI SelectedApi
        {
            get => _selectedApi;

            set
            {
                _selectedApi = value;
                
                OnPropertyChanged();
            }
        }
        
        public MainViewModel()
        {
            Apis = BaseAPI.GetApis();
        }
    }
}