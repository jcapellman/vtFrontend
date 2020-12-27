using vtFrontend.lib.Parameters.Base;

namespace vtFrontend.lib.Parameters
{
    public class FileHash : BaseParameter
    {
        public override string Label => "File Hash (SHA1/SHA256)";
        
        public override bool IsRequired => true;
    }
}