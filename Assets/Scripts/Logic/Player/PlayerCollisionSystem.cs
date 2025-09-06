using System;
using UnityEngine;

public class PlayerCollisionSystem : MonoBehaviour
{
    public event Action<int> OnCoinCollected;
    public event Action<int> OnHeartCollected;
    public event Action<int> OnBarricadeCollision;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICanBeCollision obj))
        {
            if (obj is Coin coin)
            {
                OnCoinCollected?.Invoke(coin.Value);
                coin.gameObject.SetActive(false);
            }
            else if (obj is Heart heart)
            {
                OnHeartCollected?.Invoke(heart.Value);
                heart.gameObject.SetActive(false);
            }
            else if (obj is Barricade barricade)
            {
                OnBarricadeCollision?.Invoke(barricade.Value);
                barricade.gameObject.SetActive(false);
            }
        }
    }
}
