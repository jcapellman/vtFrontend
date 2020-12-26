using vtFrontend.lib.Objects;

namespace vtFrontend.lib.APIs.Base
{
    public abstract class BaseAPI
    {
        private SettingsItem _settings;

        protected BaseAPI(SettingsItem settings)
        {
            _settings = settings;
        }

        public abstract bool Run(string[] parameters);
    }
}