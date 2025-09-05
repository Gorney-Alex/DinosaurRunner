using UnityEngine;

public class BarricadeGenerator : ObjectGenerator<Barricade>
{
    [SerializeField] private Vector3 _spawnBarricadeDirection = new Vector3(0f, 0f, 0f);
    [SerializeField] private float _distance;
    
    private void Update()
    {
        GenerateObject(_spawnBarricadeDirection, _distance); 
    }
}
