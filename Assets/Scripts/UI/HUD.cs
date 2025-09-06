using UnityEngine;

public class HUD : MonoBehaviour
{
    private UIHealth _health;
    private UIMileage _mileage;
    private UIMoney _money;

    private void Awake()
    {
        _health = GetComponent<UIHealth>();
        _mileage = GetComponent<UIMileage>();
        _money = GetComponent<UIMoney>();
    }
}
