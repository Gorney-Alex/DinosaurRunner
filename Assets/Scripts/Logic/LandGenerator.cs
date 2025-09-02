using UnityEngine;

public class LandGenerator : ObjectGenerator
{
    private Vector3 _spawnLandDirection = new Vector3(0f, 0f, 0f);
    private const int LAND_LENGTH = 10;

    private void Start()
    {
        Intialize(_objectPrefab);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime >= _secondsBetweenSpawns)
        {
            if (TryGetObject(out GameObject obj))
            {
                _currentTime = 0;
                obj.transform.position = _spawnLandDirection;
                obj.SetActive(true);
                
                _spawnLandDirection -= new Vector3(0, 0, LAND_LENGTH);
            }
        }
    }
}
