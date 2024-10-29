using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class movimientodeNave : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void ReadDirection(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();

        // Establece la velocidad directamente
        rb.velocity = new Vector3(direction.x * speed, direction.y * speed, 0f);
    }
}
