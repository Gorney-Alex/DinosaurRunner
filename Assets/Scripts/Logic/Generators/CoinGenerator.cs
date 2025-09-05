using UnityEngine;

public class CoinGenerator : ObjectGenerator<Coin>
{
    [SerializeField] private Vector3 _spawnCoinDirection = new Vector3(0f, 0f, 0f);
    [SerializeField] private float _distance;
    
    private void Update()
    {
        GenerateObject(_spawnCoinDirection, _distance); 
    }
}
