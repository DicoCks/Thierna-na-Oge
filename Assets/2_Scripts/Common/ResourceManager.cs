using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourceManager
{
    private const string prefabPath = "Prefab/";

    public static GameObject GetPrefab(string prefabName)
    {
        var prefab = Resources.Load<GameObject>($"{prefabPath}{prefabName}");
        return prefab;
    }
}
