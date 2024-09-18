using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obstaculo;
    public Vector2 spawnPos;
    public float delay = 2f;
    public float repeatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaculo, spawnPos, obstaculo.transform);
    }
}
