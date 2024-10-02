using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculo : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaculoPrefab;
    public float SpawnTimeObstaculo = 2f;
    public float VelocidadObstaculo = 1f;
    private float TiempoHastaSpawnear;

    // Update is called once per frame
    void Update()
    {
        SpawnLoop();
    }
    private void SpawnLoop()
    {
        TiempoHastaSpawnear += Time.deltaTime;

        if (TiempoHastaSpawnear >= SpawnTimeObstaculo)
        {
            Spawn();
            TiempoHastaSpawnear = 0f;
        }
    }
    private void Spawn()
    {
        GameObject obstaculoASpawnear = obstaculoPrefab[Random.Range(0, obstaculoPrefab.Length)];
        GameObject ObstaculoSpawneado = Instantiate(obstaculoASpawnear, transform.position, Quaternion.identity);
        Rigidbody2D RBobstaculo = ObstaculoSpawneado.GetComponent<Rigidbody2D>();
        RBobstaculo.velocity = Vector2.left * VelocidadObstaculo;
    }

}
