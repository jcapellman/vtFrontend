using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using vtFrontend.lib.Objects;
using vtFrontend.lib.Parameters.Base;

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

        public abstract Task<bool> RunAsync();
        
        public abstract BaseParameter[] Parameters { get; }
        
        protected string GetParameterValue(Type parameter)
        {
            if (Parameters.Length == 0)
            {
                return null;
            }

            var result = Parameters.FirstOrDefault(a => a.GetType() == parameter);

            return result?.Value;
        }
    }
}