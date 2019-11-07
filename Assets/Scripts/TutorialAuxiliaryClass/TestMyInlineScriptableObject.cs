#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

[CreateAssetMenu(fileName = "MyInline_ScriptableObject", menuName = "CreatScriptableObject/MyInlineScriptableObject")]
public class TestMyInlineScriptableObject : ScriptableObject
{
    [ShowInInlineEditors]
    public string ShownInInlineEditor;

    [HideInInlineEditors]//在绘制的里面不显示
    public string HiddenInInlineEditor;

    [DisableInInlineEditors]//显示但是是灰态
    public string DisabledInInlineEditor;
}
