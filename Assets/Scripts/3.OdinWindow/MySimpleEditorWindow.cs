#region

using Sirenix.OdinInspector.Editor;
using UnityEditor;
//using Sirenix.OdinValidator;

#endregion

public class MySimpleEditorWindow : OdinEditorWindow
{
    [MenuItem("My Game/My Simple Editor")]
    private static void OpenWindow()
    {
        GetWindow<MySimpleEditorWindow>().Show();
    }

    public string Hello = "菜鸟海澜";
}
