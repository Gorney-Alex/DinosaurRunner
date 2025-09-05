using UnityEngine;

public class PlayerWalletSystem : MonoBehaviour
{
    [SerializeField] private int _startAmountOfMoney;
    [SerializeField] private int _currentAmountOfMoney;

    public void AddMoney(int amount)
    {
        _currentAmountOfMoney += amount;
    }

    public void RemoveMoney(int amount)
    {
        if (amount > _currentAmountOfMoney)
        {
            Debug.LogError("Not enough money");
            return;
        }
        
        _currentAmountOfMoney -= amount;
    }
    
}
