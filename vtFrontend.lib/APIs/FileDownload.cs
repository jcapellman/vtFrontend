using System.Threading.Tasks;

using vtFrontend.lib.APIs.Base;
using vtFrontend.lib.Objects;
using vtFrontend.lib.Parameters;
using vtFrontend.lib.Parameters.Base;

namespace vtFrontend.lib.APIs
{
    public class FileDownload : BaseAPI
    {
        public FileDownload(SettingsItem settings) : base(settings)
        {
        }

        public override string[] Parameters => new[] {nameof(FileHash)};

        public override async Task<bool> RunAsync(BaseParameter[] parameters)
        {
            var hash = GetParameterValue(nameof(FileHash), parameters);
            
            var result = await GetByteAsync($"files/{hash}/download");

            return result != null && result.Length > 0;
        }
    }
}