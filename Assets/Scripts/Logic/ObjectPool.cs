using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool<T> : MonoBehaviour where T : Component
{
    [SerializeField] private Transform _container;
    [SerializeField] private int _amountObjects;
    
    private List<T> _pool;
    
    protected IReadOnlyList<T> Pool => _pool;

    protected void Intialize(T prefab)
    {
        _pool = new List<T>(_amountObjects);
        
        for (int i = 0; i < _amountObjects; i++)
        {
            T spawned = Instantiate(prefab, _container.transform);
            spawned.gameObject.SetActive(false);

            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out T result)
    {
        result = _pool.FirstOrDefault(obj => obj.gameObject.activeSelf == false);
        return result != null;
    }

    public void ResetPool()
    {
        foreach (var obj in _pool)
        {
            obj.gameObject.SetActive(false);
        }
    }
}
