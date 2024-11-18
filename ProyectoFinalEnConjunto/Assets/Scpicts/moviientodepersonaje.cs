using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class moviientodepersonaje : MonoBehaviour
{
    public int life = 30;
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
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Misiles") {
            
            life = life - 3;
            
            if (life == 0)
            {
                SceneManager.LoadScene("derrota");
            }
        }
        if (collision.gameObject.tag == "nave")
        {
            SceneManager.LoadScene("JuegoJefeFinal");
        }
        if (collision.gameObject.tag == "nave") {

            SceneManager.LoadScene("JuegoJefeFinal");
        }
    }
}
