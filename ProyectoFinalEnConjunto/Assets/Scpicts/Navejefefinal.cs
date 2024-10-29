using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Navejefefinal : MonoBehaviour
{
    public int life = 100;
    private Rigidbody rigibody;
    public GameObject prefabBullet;
    public GameObject PrefabMisiles;
    public Transform spawner1;
    public Transform spawner2;
    public Transform spawner3;
    public Transform spawner4;
    public Transform Spawnermisil;
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
        CrearBalalsenemigas();
        CraerMisilEnemigo();


    }
    void CrearBalalsenemigas() { 
        GameObject bullet = Instantiate(prefabBullet);
        bullet.transform.position = spawner1.position;
        bullet.transform.rotation = transform.rotation;
        Invoke("Createenemy", 0.5f);
        GameObject bullet1 = Instantiate(prefabBullet);
        bullet.transform.position = spawner2.position;
        bullet.transform.rotation = transform.rotation;
        Invoke("Createenemy", 0.5f);
        GameObject bullet2 = Instantiate(prefabBullet);
        bullet.transform.position = spawner3.position;
        bullet.transform.rotation = transform.rotation;
        Invoke("Createenemy", 0.5f);
        GameObject bullet3 = Instantiate(prefabBullet);
        bullet.transform.position = spawner4.position;
        bullet.transform.rotation = transform.rotation;
        Invoke("Createenemy", 0.5f);
    }
    void CraerMisilEnemigo() { 
        GameObject misil = Instantiate(prefabBullet);
        misil.transform.position = Spawnermisil.position;
        misil.transform.rotation = transform.rotation;
        Invoke("Createenemy", 5.0f);
    }
    private void FixedUpdate()
    {

    }
    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "baladeljugador")
        {
            life = life - 1;
            if (life == 0)
            {
                Destroy(this.gameObject);
            }
        }
        /*if (collision.gameObject.tag== "misildeljugador"){
         life = life - 10;

         }
         
         */
    }
}
