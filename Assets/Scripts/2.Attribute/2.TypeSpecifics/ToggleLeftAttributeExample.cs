#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class ToggleLeftAttributeExample : MonoBehaviour
{
    [ToggleLeft]
    public bool LeftToggled;

    public bool normalBool;
}