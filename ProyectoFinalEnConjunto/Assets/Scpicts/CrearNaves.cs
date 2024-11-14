using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearNaves : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minYposition;
    public float maxYposition;
    public float minXposition;
    public float maxXposition;
    public float zPosition;

    private void Start()
    {
        Createenemy();
    }

    void Createenemy()
    {
        float yPosition = Random.Range(minYposition, maxYposition);

        float xPosition = Random.Range(minXposition, maxXposition);

        Vector3 position = new Vector3(xPosition, yPosition, 0);

        GameObject enemy = Instantiate(prefabEnemy, position, transform.rotation);

        Invoke("Createenemy", 1.0f);
    }
}
