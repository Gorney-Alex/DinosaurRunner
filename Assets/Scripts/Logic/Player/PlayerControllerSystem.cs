using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerControllerSystem : MonoBehaviour
{
    public event UnityAction OnJump;

    private void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnJump?.Invoke();
        }
    }
}
