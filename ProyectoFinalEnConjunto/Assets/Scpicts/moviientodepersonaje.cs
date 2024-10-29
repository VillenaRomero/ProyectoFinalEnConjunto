using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class moviientodepersonaje : MonoBehaviour
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

        rb.velocity = new Vector3(direction.x * speed, 0f, direction.y * speed);
    }
}
