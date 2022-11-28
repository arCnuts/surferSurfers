
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    
    
    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();


        
    }
    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
            
        
        
        
    }

    
    void Update()
    {
        
    }
    public GameObject obstaclePrefab1;
    
    
    void SpawnObstacle ()
    {   
        //najpierw wybrac randomowe miejsce do spawnowania 
        int obstacleSpawnIndex = Random.Range(2, 5);
        
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
            Instantiate(obstaclePrefab1, spawnPoint.position, Quaternion.identity, transform);
       
        //zespawnowac obiekt w danym miejscu

    
    }
}

