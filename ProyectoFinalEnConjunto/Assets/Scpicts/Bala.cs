using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody rigibody;
    public Vector3 speedz;
    public string nametag;
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rigibody.velocity = speedz;
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == nametag)
        {
            Destroy(this.gameObject);
        }
    }

}
