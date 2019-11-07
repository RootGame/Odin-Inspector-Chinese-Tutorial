#region

using System;
using Sirenix.OdinInspector;
using UnityEngine;

#endregion

namespace D_Game.Demo
{
    public class AttributeExpressions1 : MonoBehaviour
    {
        [InfoBox(@"@""The current time is: "" + DateTime.Now.ToString(""HH:mm:ss"")")]
        public string myStrTime;

        [Button(ButtonSizes.Large)]
        public void Log()
        {
            Debug.Log(DateTime.Now.ToString("HH: mm:ss"));
        }

    }
}

