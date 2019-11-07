#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

[CreateAssetMenu(fileName = "HideMonoScript_ScriptableObject", menuName = "CreatScriptableObject/HideMonoScript")]
[HideMonoScript]
public class TestHideMonoScript : ScriptableObject
{
    public string Value;
}
