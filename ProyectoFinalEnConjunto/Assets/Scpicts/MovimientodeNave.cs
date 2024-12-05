using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;

public class MovimientodeNaveenemiga : MonoBehaviour
{
    public int life = 3;
    private Rigidbody rigibody;
    public GameObject prefabBullet;
    public Transform spawner;
    public float velocidadInicial = 5f;
    public float aceleracion = 1f;

    public float timeTiCreate = 5;
    public float currentTimetuCreate;

    private float velocidadActual;

    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
        velocidadActual = velocidadInicial;
    }

    void Update()
    {
        currentTimetuCreate += Time.deltaTime;
        if (currentTimetuCreate >= timeTiCreate)
        {
            ShootBullet1();
            currentTimetuCreate = 0;
        }
    }

    private void ShootBullet1()
    {
        GameObject bullet = Instantiate(prefabBullet);
        bullet.transform.position = spawner.position;
        bullet.transform.rotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        velocidadActual += aceleracion * Time.fixedDeltaTime;

        rigibody.velocity = new Vector3(0, 0, -velocidadActual);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            life--;
            if (life < 0)
            {
                Destroy(this.gameObject);
            }
        }

        if (collision.gameObject.tag == "nave")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "vacio")
        {
            Destroy(gameObject);
        }
    }
}
