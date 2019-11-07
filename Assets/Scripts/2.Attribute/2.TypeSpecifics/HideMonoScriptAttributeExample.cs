﻿#region

using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class HideMonoScriptAttributeExample : MonoBehaviour
    {
    [InfoBox("Click the pencil icon to open new inspector for these fields.")]
    public TestHideMonoScript Hidden;

    // The script will also be hidden for the ShowMonoScript object if MonoScripts are hidden globally.
    //如果MonoScripts是全局隐藏的，那么ShowMonoScript对象的脚本也将被隐藏。
    public TestShowMonoScript Shown;

        public void Start()
        {
            Hidden = TestExampleHelper.GetScriptableObject<TestHideMonoScript>();
            Shown = TestExampleHelper.GetScriptableObject<TestShowMonoScript>();
        }
    }


