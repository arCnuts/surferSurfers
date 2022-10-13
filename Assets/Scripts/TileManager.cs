using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnZ = 0;
    private int amnTilesOnScreen = 7;
    public float tileLength;


    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amnTilesOnScreen; i++)
        {
            SpawnTile();
        }

    }

    void Update()
    {
        if(playerTransform.position.z > (spawnZ - amnTilesOnScreen * tileLength))
        {
            SpawnTile();
        }
    }

    void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate (tilePrefabs [0]) as GameObject;
        go.transform.SetParent (transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }

}
