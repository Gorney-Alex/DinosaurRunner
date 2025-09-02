using UnityEngine;

public class ObjectGenerator : ObjectPool
{
    [SerializeField] protected GameObject _objectPrefab;
    [SerializeField] protected float _secondsBetweenSpawns;
    
    protected float _currentTime = 0;
}
