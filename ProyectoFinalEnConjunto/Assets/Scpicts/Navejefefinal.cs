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
    public float speed;
    public float xDirection = 1;
    public float yDirection = 1;
    private Transform comTransform;

    public float timeTiCreate = 5;
    public float currentTimetuCreate;

    public movimientodeNave player;
    void Start()
    {
        rigibody = GetComponent<Rigidbody>();
        comTransform = GetComponent<Transform>();
    }
    private void Update()
    {
        currentTimetuCreate = currentTimetuCreate + Time.deltaTime;
        if (currentTimetuCreate >= timeTiCreate)
        {
            ShootBullet1();
            ShootBullet2();
            ShootBullet3();
            ShootBullet4();

            currentTimetuCreate = 0;
        }

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        comTransform.position = new Vector3(comTransform.position.x + speed * xDirection * Time.deltaTime, comTransform.position.y + speed * yDirection * Time.deltaTime, 559.0f);

         
        if (comTransform.position.x >= -21019)
        {
            xDirection = -1;
        }
        else if (comTransform.position.x <= -22399)
        {
            xDirection = 1;
        }

        // Limites en y
        if (comTransform.position.y >= 555)
        {
            yDirection = -1;
        }
        else if (comTransform.position.y <= -128)
        {
            yDirection = 1;
        }
    }

    private void ShootBullet1()
    {
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
    private void ShootMisil()
    {
        GameObject misil = Instantiate(PrefabMisiles);
        misil.transform.position = Spawnermisil.position;
        misil.transform.rotation = transform.rotation;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            life = life - 1;

            if (life < 0)
            {
                Destroy(this.gameObject);
                player.OnEnemyDestroyed();
            }
        }
        /*if (collision.gameObject.tag== "misildeljugador"){
         life = life - 10;

         }
         
         */
    }

}
