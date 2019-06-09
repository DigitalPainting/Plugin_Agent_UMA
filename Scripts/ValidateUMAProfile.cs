using wizardscode.validation;

namespace wizardscode.plugin
{
    public class ValidateUMAProfile : ValidationTest<Agent_PluginManager>
    {
        public override ValidationTest<Agent_PluginManager> Instance => new ValidateUMAProfile();

        internal override string ProfileType { get { return "UMA_Agent_Profile"; } }
    }
}