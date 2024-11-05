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
    public float speedx;
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
        rigibody.velocity = new Vector3(-speedx, 0, 0);
    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            life = life - 1;
            if (life == 0)
            {
                Destroy(this.gameObject);
            }
        }
        if (collision.gameObject.tag == "player")
        {
            Destroy(this.gameObject);

        }
    }
}
