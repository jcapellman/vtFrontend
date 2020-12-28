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

        public override BaseParameter[] Parameters => new[] { new FileHash() };

        public override string Name => "File Downloader";

        public override async Task<bool> RunAsync()
        {
            var hash = GetParameterValue(typeof(FileHash));
            
            var result = await GetByteAsync($"files/{hash}/download");

            return result != null && result.Length > 0;
        }
    }
}