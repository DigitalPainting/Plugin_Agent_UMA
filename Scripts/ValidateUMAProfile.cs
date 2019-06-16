using System;
using wizardscode.validation;

namespace wizardscode.plugin
{
    public class ValidateUMAProfile : ValidationTest<Agent_PluginManager>
    {
        public override ValidationTest<Agent_PluginManager> Instance => new ValidateUMAProfile();

        internal override Type ProfileType => typeof(UMA_Agent_Profile);
    }
}