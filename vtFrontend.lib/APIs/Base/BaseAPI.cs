using System.Net.Http;
using System.Threading.Tasks;

using vtFrontend.lib.Objects;

namespace vtFrontend.lib.APIs.Base
{
    public abstract class BaseAPI
    {
        private const string VtBaseurl = "https://www.virustotal.com/api/v3/";
        
        private readonly SettingsItem _settings;

        protected BaseAPI(SettingsItem settings)
        {
            _settings = settings;
        }

        protected async Task<byte[]> GetByteAsync(string url)
        {
            using var httpClient = new HttpClient();
            
            httpClient.DefaultRequestHeaders.Add("x-apikey", _settings.VTKey);

            return await httpClient.GetByteArrayAsync(
                $"{VtBaseurl}{url}");
        }
        
        public abstract Task<bool> RunAsync(string[] parameters);
    }
}