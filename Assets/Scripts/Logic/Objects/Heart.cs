using UnityEngine;

public class Heart : WorldObject, ICanBeCollision
{
    [SerializeField] protected int _value;
    
    public int Value => _value;
}
