using System;
using WizardsCode.Validation;

namespace WizardsCode.Plugin
{
    public class ValidateUMAProfile : ValidationTest<Agent_PluginManager>
    {
        public override ValidationTest<Agent_PluginManager> Instance => new ValidateUMAProfile();

        internal override Type ProfileType => typeof(UMA_Agent_Profile);
    }
}