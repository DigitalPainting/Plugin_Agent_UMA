using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using WizardsCode.editor;
using WizardsCode.validation;

namespace WizardsCode.plugin
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
