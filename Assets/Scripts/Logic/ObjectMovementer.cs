using System.Collections.Generic;
using UnityEngine;


public class ObjectMovementer : MonoBehaviour
{
    private static List<Transform> _objects = new List<Transform>();
    [SerializeField] private Transform _container;

    private void Start()
    {
        foreach (Transform child in _container)
        {
            _objects.Add(child);
        }
    }

    private void Update()
    {
        MoveAllObjects();
    }

    private void MoveAllObjects()
    {
        foreach (var obj in _objects)
        {
            if (obj.gameObject.activeSelf)
            {
                obj.transform.Translate(Vector3.forward * 20 * Time.deltaTime, Space.World);
            }
        }
    }
}
