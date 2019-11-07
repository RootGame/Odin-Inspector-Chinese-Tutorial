#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class EnableGUIExample : MonoBehaviour
{
    [ShowInInspector]
    public int GUIDisabledProperty { get { return 20; } }

    [ShowInInspector, EnableGUI]
    public int GUIEnabledProperty { get { return 10; } }
}
