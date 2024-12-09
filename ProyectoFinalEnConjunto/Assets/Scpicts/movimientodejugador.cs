using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class movimientodeNave : MonoBehaviour
{
    public int life = 30;
    private Rigidbody rb;
    public float speed = 100f;
    public GameObject bulletprefab;
    public Transform spawner;
    public string nivel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void ReadDirection(InputAction.CallbackContext context)
    {
        Vector2 direction = context.ReadValue<Vector2>();

        rb.velocity = new Vector3(direction.x * speed, direction.y * speed, 0f);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject bullet = Instantiate(bulletprefab);
            bullet.transform.position = spawner.position;
            bullet.transform.rotation = transform.rotation;
        }
    }
    public void OnEnemyDestroyed()
    {
        SceneManager.LoadScene(nivel);
    }
    public void OnCollisionEnter(Collision collision)
    { 
 
        if (collision.gameObject.tag == "Balasenemigas")
        {

            life = life - 1;

            if (life < 0)
            {
                SceneManager.LoadScene("derrota");
            }
        }
        if (collision.gameObject.tag == "NaveEnemiga")
        {

            life = life - 1;

            if (life < 0)
            {
                SceneManager.LoadScene("derrota");
            }
        }
    }

}