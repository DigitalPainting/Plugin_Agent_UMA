using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wizardscode.plugin;

namespace wizardscode.plugin {
    public class Agent_UMA_PluginDefinition : AbstractPluginDefinition
    {
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
            throw new NotImplementedException();
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