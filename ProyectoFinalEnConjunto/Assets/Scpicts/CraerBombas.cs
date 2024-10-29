using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearBombas : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minZposition;
    public float maxZposition;
    public float yPosition;

    private void Awake()
    {
        Createenemy();
    }

    void Createenemy()
    {
        float zPosition = Random.Range(minZposition, maxZposition);

        Vector3 position = new Vector3(0f, yPosition, zPosition);

        GameObject enemy = Instantiate(prefabEnemy, position, transform.rotation);

        Invoke("Createenemy", 1.0f);
    }
}
