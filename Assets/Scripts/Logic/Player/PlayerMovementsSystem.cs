using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovementsSystem : MonoBehaviour
{
    [SerializeField] private float ForceJump;

    private Rigidbody _playerRigidbody;

    public PlayerMovementsSystem(Rigidbody playerRigidbody)
    {
        _playerRigidbody = playerRigidbody;
    }

    public void Jump()
    {
        _playerRigidbody.AddForce(Vector3.up * ForceJump, ForceMode.Impulse);
    }
}
