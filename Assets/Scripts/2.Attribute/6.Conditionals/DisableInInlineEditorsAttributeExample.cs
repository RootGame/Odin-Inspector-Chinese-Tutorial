#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class DisableInInlineEditorsAttributeExample : MonoBehaviour
{
    [InfoBox("Click the pen icon to open a new inspector window for the InlineObject too see the difference this attribute make.")]
    [InlineEditor(Expanded = true)]
    public TestMyInlineScriptableObject InlineObject ;
}
