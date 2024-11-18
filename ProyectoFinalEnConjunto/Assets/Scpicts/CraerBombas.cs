using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearBombas : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minZposition;
    public float maxZposition;
    public float minXposition;
    public float maxXposition;
    public float yPosition;

    private void Awake()
    {
        Createenemy();
    }

    void Createenemy()
    {
        float zPosition = Random.Range(minZposition, maxZposition);

        float xPosition = Random.Range(minXposition, maxXposition);

        Vector3 position = new Vector3(xPosition, yPosition, zPosition);

        GameObject enemy = Instantiate(prefabEnemy, position, transform.rotation);

        Invoke("Createenemy", 5.0f);
    }
}
