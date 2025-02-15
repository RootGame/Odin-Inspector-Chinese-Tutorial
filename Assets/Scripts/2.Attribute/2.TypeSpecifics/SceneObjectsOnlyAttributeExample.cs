﻿#region

using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class SceneObjectsOnlyAttributeExample : MonoBehaviour
    {
    [Title("Assets only")]
    [AssetsOnly]
    public List<GameObject> OnlyPrefabs;

    [AssetsOnly]
    public GameObject SomePrefab;

    [AssetsOnly]
    public Material MaterialAsset;

    [AssetsOnly]
    public MeshRenderer SomeMeshRendererOnPrefab;

    [Title("Scene Objects only")]
    [SceneObjectsOnly]
    public List<GameObject> OnlySceneObjects;

    [SceneObjectsOnly]
    public GameObject SomeSceneObject;

    [SceneObjectsOnly]
    public MeshRenderer SomeMeshRenderer;
}