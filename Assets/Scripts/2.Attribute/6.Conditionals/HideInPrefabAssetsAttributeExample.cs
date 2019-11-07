#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class HideInPrefabAssetsAttributeExample : MonoBehaviour
{
    [HideInPrefabAssets] //在Asset中且是预制体时隐藏
    public GameObject HiddenInPrefabAssets;
}
