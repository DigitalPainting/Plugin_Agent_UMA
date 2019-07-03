using System;
using WizardsCode.validation;

namespace WizardsCode.plugin
{
    public class ValidateUMAProfile : ValidationTest<Agent_PluginManager>
    {
        public override ValidationTest<Agent_PluginManager> Instance => new ValidateUMAProfile();

        internal override Type ProfileType => typeof(UMA_Agent_Profile);
    }
}