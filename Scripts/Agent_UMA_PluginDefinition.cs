using System;

namespace WizardsCode.Plugin {
    public class Agent_UMA_PluginDefinition : AbstractPluginDefinition
    {
        public override bool MultipleAllowed
        {
            get { return true; }
        }

        public override PluginCategory GetCategory()
        {
            return PluginCategory.Agent;
        }

        public override Type GetManagerType()
        {
            return typeof(Agent_PluginManager);
        }

        public override string GetPluginImplementationClassName()
        {
            return "DynamicCharacterAvatar";
        }

        public override string GetProfileTypeName()
        {
            return "UMA_Agent_Profile";
        }

        public override string GetReadableName()
        {
            return "UMA Agent";
        }

        public override string GetURL()
        {
            return "https://assetstore.unity.com/packages/3d/characters/uma-2-unity-multipurpose-avatar-35611";
        }
    }
}