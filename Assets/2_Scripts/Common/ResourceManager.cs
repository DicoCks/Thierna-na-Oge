using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourceManager
{
    private const string prefabPath = "Prefab/";

    public static GameObject GetPrefab(string prefabName, Transform parent = null)
    {
        var prefab = Resources.Load<GameObject>($"{prefabPath}{prefabName}");
        var obj = parent == null ? Object.Instantiate(prefab) : Object.Instantiate(prefab,parent);
        return obj;
    }
}
