using System.Collections.Generic;
using UnityEngine;

public static class ObjectDataBase
{
    private static List<GameObject> _objects = new List<GameObject>();

    public static IReadOnlyList<GameObject> Objects => _objects;

    public static void AddToList(GameObject worldObject)
    {
        _objects.Add(worldObject);
    }
}
