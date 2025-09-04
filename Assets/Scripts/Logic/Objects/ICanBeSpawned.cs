using UnityEngine;

public interface ICanBeSpawned
{
    public void OnSpawned()
    {
        Debug.Log("Object is Spawned");
    }
}
