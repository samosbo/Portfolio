
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Purpose: Controls spawning paws and making them equally distance apart so it is playable

public class PipeSpawnScript : MonoBehaviour
{
    //declare variables
    public GameObject paw;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 15;

    /// <summary>
    /// Spawns Paw initially to quicken speed of waiting for first paw
    /// </summary>
    void Start()
    {
        SpawnPipe();
    }

    /// <summary>
    /// Makes it so a paw is spawned with a gap in between
    /// </summary>
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
        
    }

    /// <summary>
    /// SPawns Pipes in between height offset when playing
    /// </summary>
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(paw, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

}
