#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class HideInPlayModeAttributeExample : MonoBehaviour
{
    [Title("Hidden in play mode")]
    [HideInPlayMode]
    public int A;

    [HideInPlayMode]
    public int B;
}
