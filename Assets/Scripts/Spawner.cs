using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public int numberofenemies;
    public float spawnTime = 3f;
    private float spawnRadius = 1;
    private Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
        InvokeRepeating("SpawnObject", spawnTime, spawnTime);
    }

    
    void SpawnObject()
    {

        for(int i=0;i<numberofenemies;i++)
        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
        }
    }

}
