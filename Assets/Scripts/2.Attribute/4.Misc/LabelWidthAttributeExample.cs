#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class LabelWidthAttributeExample : MonoBehaviour
{
    public int DefaultWidth;

    [LabelWidth(50)]
    public int Thin;

    [LabelWidth(250)]
    public int Wide;
}
