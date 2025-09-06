using System;
using UnityEngine;

public class PlayerWalletSystem : MonoBehaviour
{
    [SerializeField] private int _startAmountOfMoney;
    
    private int _currentAmountOfMoney;

    private void Awake()
    {
        _currentAmountOfMoney = _startAmountOfMoney;
    }

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
