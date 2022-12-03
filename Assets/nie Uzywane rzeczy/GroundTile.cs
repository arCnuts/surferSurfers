
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    [SerializeField] GameObject[] prefabs;
    public GameObject obstaclePrefab;
    
    
    
    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnPrefab();
        
    }
    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
        void SpawnPrefab ()
    {   
        //najpierw wybrac randomowe miejsce do spawnowania 
        int obstacleSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
        
}

