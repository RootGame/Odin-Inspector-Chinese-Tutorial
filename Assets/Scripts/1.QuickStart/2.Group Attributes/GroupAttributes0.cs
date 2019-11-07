#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

namespace D_Game.Demo
{
    public class GroupAttributes0 : MonoBehaviour
    {
        [TabGroup("First Tab")]
        public int FirstTab;

        [ShowInInspector, TabGroup("First Tab")]
        public int SecondTab { get; set; }

        [TabGroup("Second Tab")]
        public float FloatValue;

        [TabGroup("Second Tab"), Button]
        public void Button()
        {
            Debug.Log("HelloWorld");
        }
    }
}

