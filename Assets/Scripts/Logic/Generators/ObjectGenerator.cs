using UnityEngine;

public class ObjectGenerator<T> : ObjectPool <T> where T : Component 
{
    [SerializeField] protected T _objectPrefab;
    [SerializeField] protected float _secondsBetweenSpawns;
    
    private Vector3 _spawnLandDirection = new Vector3(0f, 0f, 0f);
    private const int LAND_LENGTH = 10;
    
    protected float _currentTime = 0;
    
    private void Awake()
    {
        Intialize(_objectPrefab);
    }
    
    private void Update()
    {
        GenerateObject(); 
    }

    private void GenerateObject()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _secondsBetweenSpawns)
        {
            if (TryGetObject(out T obj))
            {
                _currentTime = 0;
                obj.transform.position = _spawnLandDirection;
                obj.gameObject.SetActive(true);
                
                _spawnLandDirection -= new Vector3(0, 0, LAND_LENGTH);
            }
        }
    }
}
