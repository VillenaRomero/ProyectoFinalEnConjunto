using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody rigibody;
    public Vector3 speedz;
    public string nametag;
    public string nametag2;
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rigibody.velocity = speedz;
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
