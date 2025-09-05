using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerControllerSystem _playerControllerSystem;
    [SerializeField] private PlayerMovementsSystem _playerMovementsSystem;
    [SerializeField] private PlayerLiveSystem _playerLiveSystem;
    [SerializeField] private PlayerCollisionSystem _playerCollisionSystem;
    
    public event UnityAction<int> OnHeartAmountChanged; 
    public event UnityAction<int> OnMoneyAmountChanged; 
    public event UnityAction OnPlayerDie;

    public void TakeDamage(int amountDamage)
    {
        Debug.Log("Player taking damage!");
        OnHeartAmountChanged?.Invoke(amountDamage);
    }

    public void Buy(int amountMoney)
    {
        Debug.Log("Buy!");
        OnMoneyAmountChanged?.Invoke(amountMoney);
    }

    public void Die()
    {
        Debug.Log("Player dying!");
    }
}
