using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private int _amountObjects;
    
    private List<GameObject> _pool = new List<GameObject>();

    protected void Intialize(GameObject prefab)
    {
        for (int i = 0; i < _amountObjects; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);
            
            ObjectDataBase.AddToList(spawned);
            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(obj => obj.activeSelf == false);
        return result != null;
    }

    public void ResetPool()
    {
        foreach (var obj in _pool)
        {
            obj.SetActive(false);
        }
    }
}
