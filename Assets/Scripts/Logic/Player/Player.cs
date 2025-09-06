using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerControllerSystem _controllerSystem;
    private PlayerMovementsSystem _movementsSystem;
    private PlayerLiveSystem _liveSystem;
    private PlayerCollisionSystem _collisionSystem;
    private PlayerWalletSystem _walletSystem;

    private void OnEnable()
    {
        _controllerSystem.OnJump += Jump;
        
        _collisionSystem.OnCoinCollected += CollectCoin;
        _collisionSystem.OnHeartCollected += CollectHeart;
        _collisionSystem.OnBarricadeCollision += TakeDamage;

        _liveSystem.Die += Die;
    }
    
    private void OnDisable()
    {
        _controllerSystem.OnJump -= Jump;
        
        _collisionSystem.OnCoinCollected -= CollectCoin;
        _collisionSystem.OnHeartCollected -= CollectHeart;
        _collisionSystem.OnBarricadeCollision -= TakeDamage;
        
        _liveSystem.Die -= Die;
    }

    private void Awake()
    {
        _movementsSystem = GetComponent<PlayerMovementsSystem>();
        _collisionSystem = GetComponent<PlayerCollisionSystem>();
        _walletSystem = GetComponent<PlayerWalletSystem>();
        _liveSystem = GetComponent<PlayerLiveSystem>();
        _controllerSystem = GetComponent<PlayerControllerSystem>();
    }

    private void CollectHeart(int amountHeart)
    {
        _liveSystem.AddHeart(amountHeart);
    }

    private void CollectCoin(int amountMoney)
    {
        _walletSystem.AddMoney(amountMoney);
    }

    private void Jump()
    {
        _movementsSystem.Jump();
    }

    public void TakeDamage(int amountDamage)
    {
        _liveSystem.RemoveHeart(amountDamage);
    }

    public void Buy(int amountMoney)
    {
        Debug.Log("Buy!");
    }

    public void Die()
    {
        Debug.Log("Player dying!");
    }
}
