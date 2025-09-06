using UnityEngine;

public class Barricade : WorldObject, ICanBeCollision
{
    [SerializeField] protected int _value;
    
    public int Value => _value;
}
