using UnityEngine;

public class WallDisabler : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Object obj))
        {
            obj.gameObject.SetActive(false);
            obj.transform.position = _container.transform.position;
        }
    }
}
