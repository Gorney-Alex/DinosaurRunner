using UnityEngine;

public class HeartGenerator : ObjectGenerator<Heart>
{
    [SerializeField] private Vector3 _spawnHeartDirection = new Vector3(0f, 0f, 0f);
    [SerializeField] private float _distance;
    
    private void Update()
    {
        GenerateObject(_spawnHeartDirection, _distance); 
    }
}
