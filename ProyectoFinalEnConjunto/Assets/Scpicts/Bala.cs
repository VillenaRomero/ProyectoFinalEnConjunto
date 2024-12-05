using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody rigibody;
    public float fuerzaImpulso = 10f; // Fuerza del impulso inicial
    public string nametag;
    public string nametag2;
    private Vector3 velocidadActual; // Velocidad actual de la bala

    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        // Aplicar el impulso inicial
        rigibody.AddForce(transform.forward * fuerzaImpulso, ForceMode.Impulse);
    }
    private void FixedUpdate()
    {
        // Actualizar la velocidad actual
        velocidadActual = rigibody.velocity;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == nametag2)
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "vacio")
        {
            Destroy(this.gameObject);
        }
    }
}
