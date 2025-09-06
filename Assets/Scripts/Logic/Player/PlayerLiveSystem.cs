using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerLiveSystem : MonoBehaviour
{
    [SerializeField] private int _maxHeartAmount;
    
    private int _currentHeartAmount;

    private void Awake()
    {
        _currentHeartAmount = _maxHeartAmount;
    }

    public void AddHeart(int heartAmount)
    {
        _currentHeartAmount += heartAmount;
        
        if (_currentHeartAmount >= _maxHeartAmount)
        {
            _currentHeartAmount = _maxHeartAmount;
        }
    }

    public void RemoveHeart(int heartAmount)
    {
        _currentHeartAmount -= heartAmount;

        if (_currentHeartAmount <= 0)
        {
            
        }
    }
    
}
