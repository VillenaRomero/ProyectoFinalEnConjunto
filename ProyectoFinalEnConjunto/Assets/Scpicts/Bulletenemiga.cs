using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletenemiga : MonoBehaviour
{
    private Rigidbody rigibody;
    public float speedx;
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
        rigibody.velocity = new Vector3(-speedx, 0, 0);
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
        }
    }
}
