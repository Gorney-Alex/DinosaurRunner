using UnityEngine;

public class WallDisabler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Object obj))
        {
            obj.gameObject.SetActive(false);
            Debug.Log("WallDisabler entered");
        }
    }
}
