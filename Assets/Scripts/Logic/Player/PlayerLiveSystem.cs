using UnityEngine;

public class PlayerLiveSystem : MonoBehaviour
{
    [SerializeField] private int _maxHeartAmount;
    [SerializeField] private int _currentHeartAmount;

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
