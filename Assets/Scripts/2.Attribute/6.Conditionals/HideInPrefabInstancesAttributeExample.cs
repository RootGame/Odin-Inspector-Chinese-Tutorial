#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class HideInPrefabInstancesAttributeExample : MonoBehaviour
{
    [HideInPrefabInstances]
    public GameObject HiddenInPrefabInstances;
}
