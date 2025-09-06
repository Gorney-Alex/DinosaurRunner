using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementsSystem : MonoBehaviour
{
    [SerializeField] private float ForceJump;

    private Rigidbody _playerRigidbody;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        _playerRigidbody.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
    }
}
