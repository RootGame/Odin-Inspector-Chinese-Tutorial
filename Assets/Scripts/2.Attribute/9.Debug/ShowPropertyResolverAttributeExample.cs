#region

using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class ShowPropertyResolverAttributeExample : MonoBehaviour
{
    [ShowPropertyResolver]
    public string MyString;

    [ShowPropertyResolver]
    public List<int> MyList;

    [ShowInInspector]
    [ShowPropertyResolver]
    public Dictionary<int, Vector3> MyDictionary;
}
