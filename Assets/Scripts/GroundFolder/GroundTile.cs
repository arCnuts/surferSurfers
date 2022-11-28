
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    
    
    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
        SpawnObstacle2();


        
    }
    private void OnTriggerExit(Collider other) {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
            
        
        
        
    }

    
    void Update()
    {
        
    }
    public GameObject obstaclePrefab1;
    public GameObject obstaclePrefab2;
    
    
    void SpawnObstacle ()
    {   
        //najpierw wybrac randomowe miejsce do spawnowania 
        int obstacleSpawnIndex = Random.Range(2, 5);
        
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        Instantiate(obstaclePrefab2, spawnPoint.position, Quaternion.identity, transform);
       
        //zespawnowac obiekt w danym miejscu

    
    }
        void SpawnObstacle2 ()
    {   
        
        int obstacleSpawnIndex = Random.Range(2, 5);
        
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        Instantiate(obstaclePrefab1, spawnPoint.position, Quaternion.identity, transform);
            
       
        

    
    }
}

