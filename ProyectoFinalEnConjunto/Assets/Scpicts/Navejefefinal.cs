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
        InvokeRepeating("ShootBullet1", 0f, 5f);
        InvokeRepeating("ShootBullet2", 0f, 5f);
        InvokeRepeating("ShootBullet3", 0f, 5f);
        InvokeRepeating("ShootBullet4", 0f, 5f);
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       
    }
    private void ShootBullet1() {
        GameObject bullet = Instantiate(prefabBullet);
        bullet.transform.position = spawner1.position;
        bullet.transform.rotation = transform.rotation;  
    }
    private void ShootBullet2()
    {
        GameObject bullet = Instantiate(prefabBullet);
        bullet.transform.position = spawner2.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void ShootBullet3()
    {
        GameObject bullet = Instantiate(prefabBullet);
        bullet.transform.position = spawner3.position;
        bullet.transform.rotation = transform.rotation;
    }
    private void ShootBullet4()
    {
        GameObject bullet = Instantiate(prefabBullet);
        bullet.transform.position = spawner4.position;
        bullet.transform.rotation = transform.rotation;
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
