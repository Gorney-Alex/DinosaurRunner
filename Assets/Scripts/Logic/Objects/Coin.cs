using UnityEngine;

public class Coin : WorldObject, ICanBeCollision
{
    [SerializeField] protected int _value;
    
    public int Value => _value;
}
