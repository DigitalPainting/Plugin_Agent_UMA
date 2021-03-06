﻿using UnityEngine;
using WizardsCode.Editor;
using WizardsCode.Validation;

namespace WizardsCode.Plugin
{
    [CreateAssetMenu(fileName = "UMA_Agent_Profile", menuName = "Wizards Code/Agent/UMA Profile")]
    class UMA_Agent_Profile : AbstractPluginProfile
    {
        [Tooltip("The UMA DCS prefab that provides all the necessary code to create UMA characters.")]
        [Expandable(isRequired: true)]
        public PrefabSettingSO UMAPrefab;
        
        [Tooltip("The definition of the UMA character to spawn.")]
        [Expandable(isRequired: true)]
        public UMASettingSO agent;
    }
}
