#region

using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

#endregion

public class AssetsOnlyExample : MonoBehaviour
{
    [AssetsOnly]
    public List<GameObject> assetsOnlyPrefabList;

    [AssetsOnly]
    public GameObject ssetsOnlyPrefab;

    [AssetsOnly]
    public Material assetsOnlyMaterial;

    [AssetsOnly]
    public MeshRenderer someMeshRendererOnPrefab;

    [SceneObjectsOnly]
    public List<GameObject> onlySceneObjectList;

    [SceneObjectsOnly]
    public GameObject someSceneObject;

    [SceneObjectsOnly]
    public MeshRenderer someMeshRendererInScene;
}
