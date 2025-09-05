using System.Collections.Generic;
using UnityEngine;


public class ObjectMovementer : MonoBehaviour
{
    private List<Transform> _objects;
    [SerializeField] private Transform _container;

    private void Start()
    {
        _objects = new List<Transform>();
        
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
                obj.transform.Translate(Vector3.forward * 10 * Time.deltaTime, Space.World);
            }
        }
    }
}
