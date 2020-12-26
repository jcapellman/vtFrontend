using System.Threading.Tasks;

using vtFrontend.lib.APIs.Base;
using vtFrontend.lib.Objects;

namespace vtFrontend.lib.APIs
{
    public class FileDownload : BaseAPI
    {
        public FileDownload(SettingsItem settings) : base(settings)
        {
        }
        
        public override async Task<bool> RunAsync(string[] parameters)
        {
            var result = await GetByteAsync($"files/{parameters[0]}/download");

            return result != null && result.Length > 0;
        }
    }
}