using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;

    public float maxX;
    public float maxY;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        // spawnBall();
        InvokeRepeating("spawnBall", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            spawnBall();
        }

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = 10f;
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);
            Instantiate(ball, spawnPos, Quaternion.identity);
        }
    }
    void spawnBall()
    {
        float randomX = Random.Range(-maxX, maxX);
        float RandomZ = Random.Range(-maxZ,maxZ);
        float RandomY = Random.Range(- maxY, maxY);

        Vector3 randomSpawnPoint = new Vector3(randomX, 10f, RandomZ); ;


        Instantiate(ball, randomSpawnPoint, Quaternion.identity);
    }
}
