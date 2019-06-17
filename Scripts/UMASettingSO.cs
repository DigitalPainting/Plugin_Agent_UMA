using UMA;
using UnityEngine;

namespace wizardscode.validation
{
    [CreateAssetMenu(fileName = "UMASettingSO_DESCRIPTIVENAME", menuName = "Wizards Code/Validation/UMA/UMA Setting SO")]
    public class UMASettingSO : AgentSettingSO
    {

        internal override void InstantiatePrefab()
        {
            base.InstantiatePrefab();
            UMARandomAvatar randomAvatar = Instance.GetComponent<UMARandomAvatar>();
            if (randomAvatar)
            {
                randomAvatar.NameBase = agentName;
                randomAvatar.ParentObject = Instance;
                PositionOnGround(spawnPosition);
            }
        }
    }
}
