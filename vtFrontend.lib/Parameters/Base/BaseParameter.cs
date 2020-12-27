namespace vtFrontend.lib.Parameters.Base
{
    public abstract class BaseParameter
    {
        public abstract string Label { get; }
        
        public abstract bool IsRequired { get; }
        
        public string Value { get; set; }
    }
}