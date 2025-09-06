using UnityEngine;
using UnityEngine.Events;

public class PlayerWalletSystem : MonoBehaviour
{
    [SerializeField] private int _startAmountOfMoney;
    
    private int _currentAmountOfMoney;
    
    public event UnityAction<int> OnMoneyChanged;

    private void Awake()
    {
        _currentAmountOfMoney = _startAmountOfMoney;
        
        OnMoneyChanged?.Invoke(_currentAmountOfMoney);
    }

    public void AddMoney(int amount)
    {
        _currentAmountOfMoney += amount;
        OnMoneyChanged?.Invoke(_currentAmountOfMoney);
    }

    public void RemoveMoney(int amount)
    {
        if (amount > _currentAmountOfMoney)
        {
            Debug.LogError("Not enough money");
            return;
        }
        
        _currentAmountOfMoney -= amount;
        OnMoneyChanged?.Invoke(_currentAmountOfMoney);
    }
    
}
