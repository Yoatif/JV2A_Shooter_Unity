using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //creating a list where prefabs animals are stocked
    public GameObject enemyPrefabs;
    // creating range for spawn
    public Transform limitL;
    public Transform limitR;
    public Transform limitS;
    //creating an interval for the spawn
    public float startDelay = 2f;
    public float spawnInterval = 3f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {







    }
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(limitL.position.x, limitR.position.x), limitS.position.y, limitS.position.y);
        
        Instantiate(enemyPrefabs, spawnPos,
            enemyPrefabs.transform.rotation);



    }
}
