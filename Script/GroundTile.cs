using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GroundTile : MonoBehaviour
{
    // Start is called before the first frame update
    private GroundSpawn _groundSpawn;
    private void Start()
    {
        _groundSpawn = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        _groundSpawn.SpawnTile();
        Destroy(gameObject,0.5f);
    }

    public GameObject ObstaclePrefab;
    public GameObject ObjetivePrefab;


    void SpawnObstacle()
    {
        //elegir un punto aleatorio para el obstaculo
        int ObstacleSpawnIndex = Random.Range(8, 11);
        int ObjetiveSpawnIndex = Random.Range(11, 14);
        Transform spawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;
        Transform spawnPoint2 = transform.GetChild(ObjetiveSpawnIndex).transform;


        //Generar obstaculo en esa posicion
        Instantiate(ObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        Instantiate(ObjetivePrefab, spawnPoint2.position, Quaternion.identity, transform);

        
    }
}
