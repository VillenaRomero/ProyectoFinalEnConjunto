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
    public Vector2 sensitivity;
    public float timeTiCreate = 30;
    public float currentTimetuCreate;
    public string nivel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        UpdateCamera();
        currentTimetuCreate = currentTimetuCreate + Time.deltaTime;
        if (currentTimetuCreate >= timeTiCreate)
        {
            SceneManager.LoadScene(nivel);
        }
    }
    private void UpdateCamera() {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        if (hor != 0) {
            transform.Rotate(0,hor * sensitivity.x, 0);
        }
        if (ver != 0)
        {
            transform.Rotate(ver * sensitivity.y,0, 0);
        }
    }
    public void ReadDirection(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();

        rb.velocity = new Vector3(direction.x * speed, 0f, direction.y * speed);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Misiles") {
            
            life = life - 1;
            
            if (life < 0)
            {
                SceneManager.LoadScene("derrota");
            }
        }
        if (collision.gameObject.tag == "nave")
        {
            SceneManager.LoadScene("JuegoJefeFinal");
        }
    }
}
