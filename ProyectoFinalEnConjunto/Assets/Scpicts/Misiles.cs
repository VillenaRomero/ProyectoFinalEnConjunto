using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misiles : MonoBehaviour
{
    private Rigidbody rigibody;
    public float speedy;
    void Start()
    {
               rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {

    }
    private void FixedUpdate()
    {
        rigibody.velocity = new Vector3(0, -speedy, 0);
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);

        }
    }
}
