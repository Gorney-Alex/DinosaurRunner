using UnityEngine;

public class ObjectGenerator<T> : ObjectPool<T> where T : Component 
{
    [SerializeField] protected T _objectPrefab;
    [SerializeField] protected float _secondsBetweenSpawns;
    
    protected float _currentTime = 0;
    
    private Vector3 _lastSpawnedPosition;
    private bool _isFirstSpawn = true;
    
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
                
                if (_isFirstSpawn)
                {
                    spawnPosition = initialPosition;
                    _isFirstSpawn = false;
                }
                else
                {
                    spawnPosition = _lastSpawnedPosition + new Vector3(0f, 0f, -distance);
                }
                
                obj.transform.position = spawnPosition;
                obj.gameObject.SetActive(true);
                
                _lastSpawnedPosition = spawnPosition;
                
                _currentTime = 0f;
            }
        }
    }
}