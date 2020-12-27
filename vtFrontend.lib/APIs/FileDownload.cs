using System.Threading.Tasks;

using vtFrontend.lib.APIs.Base;
using vtFrontend.lib.Objects;
using vtFrontend.lib.Parameters.Base;

namespace vtFrontend.lib.APIs
{
    public class FileDownload : BaseAPI
    {
        public FileDownload(SettingsItem settings) : base(settings)
        {
        }
        
        public override async Task<bool> RunAsync(BaseParameter[] parameters)
        {
            var result = await GetByteAsync($"files/{parameters[0].Value}/download");

            return result != null && result.Length > 0;
        }
    }
}