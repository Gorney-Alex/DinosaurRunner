using UnityEngine;

public class LandGenerator : ObjectGenerator<Land>
{
    [SerializeField] private Vector3 _spawnLandDirection = new Vector3(0f, 0f, 0f);
    [SerializeField] private float _distance;
    
    private void Update()
    {
        GenerateObject(_spawnLandDirection, _distance); 
    }
}
