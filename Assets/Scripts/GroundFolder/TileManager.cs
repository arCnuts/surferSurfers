using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour

{
    [SerializeField] GameObject[] Prefabs;
    public float zSpawn = 0;
    [SerializeField]public float tileLength = 10;
    [SerializeField]public int numberOfTiles = 45;
    public Transform playerTransform;
    private List<GameObject> activeTiles = new List<GameObject>();
    
    
    void Start()
    {
        for(int i = 0; i <45; i++)
        {
            SpawnTile(Random.Range(0,Prefabs.Length));
        }
    }

    
    void Update()
    {
        if(playerTransform.position.z - 35 >zSpawn - (numberOfTiles * tileLength))
        {
            SpawnTile(Random.Range(0,Prefabs.Length));
            DeleteTile();
        }
        
    }
    public void SpawnTile( int tileIndex)
    {

        GameObject go = Instantiate(Prefabs[tileIndex], transform.forward * zSpawn, transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLength;
}
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}

