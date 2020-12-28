using System.Collections.Generic;
using System.Linq;

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

        private bool _enableExecuteButton;

        public bool EnableExecuteButton
        {
            get => _enableExecuteButton;

            set
            {
                _enableExecuteButton = value;
                
                OnPropertyChanged();
            }
        }

        public void ValidateForm()
        {
            var valid = !string.IsNullOrEmpty(Settings.VTKey);

            foreach (var parameter in SelectedApi.Parameters)
            {
                if (parameter.IsRequired && string.IsNullOrEmpty(parameter.Value))
                {
                    valid = false;
                }
            }
            
            EnableExecuteButton = valid;
        }
        
        public MainViewModel()
        {
            Settings = new SettingsItem();
            
            Apis = BaseAPI.GetApis(Settings);

            SelectedApi = Apis.FirstOrDefault();

            ValidateForm();
        }

        public void ResetFields()
        {
            foreach (var parameter in SelectedApi.Parameters)
            {
                parameter.Value = null;
            }
        }

        public async void ExecuteApi()
        {
            var result = await SelectedApi.RunAsync();
        }
    }
}