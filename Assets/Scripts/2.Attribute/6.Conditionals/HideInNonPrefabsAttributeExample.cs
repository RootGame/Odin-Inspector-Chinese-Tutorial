#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class HideInNonPrefabsAttributeExample : MonoBehaviour
{
    [HideInNonPrefabs] //非预制体时隐藏属性
    public GameObject HiddenInNonPrefabs;
}
