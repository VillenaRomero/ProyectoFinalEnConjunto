using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody rigibody;
    public float speedz;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rigibody.velocity = new Vector3(0,0,speedz);
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
