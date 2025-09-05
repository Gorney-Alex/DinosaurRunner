using UnityEngine;

public class ObjectGenerator<T> : ObjectPool<T> where T : Component 
{
    [SerializeField] protected T _objectPrefab;
    [SerializeField] protected float _secondsBetweenSpawns;
    
    protected float _currentTime = 0;
    private Vector3 _lastSpawnPosition;
    private bool _firstSpawn = true;
    
    private void Awake()
    {
        Intialize(_objectPrefab);
    }

    protected void GenerateObject(Vector3 initialPosition, float distance)
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _secondsBetweenSpawns)
        {
            if (TryGetObject(out T obj))
            {
                Vector3 spawnPosition;
                
                if (_firstSpawn)
                {
                    spawnPosition = initialPosition;
                    _firstSpawn = false;
                }
                else
                {
                    spawnPosition = _lastSpawnPosition + new Vector3(0f, 0f, -distance);
                }
                
                obj.transform.position = spawnPosition;
                obj.gameObject.SetActive(true);
                
                _lastSpawnPosition = spawnPosition;
                
                _currentTime = 0f;
            }
        }
    }
}