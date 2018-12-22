using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spa : MonoBehaviour {

    public Transform ufo;

    public float maxSpawnInterval;
    public float minSpawnInterval;
    public float spawnIncreaseOverTime;
    public float minimumCapInterval;

    private float finalSpawnIncrease;

    private float randomizedSpawnInterval;
    private float initialSpawnTime;

    private float currentTime;
    private float cooldownTime;
    private bool spawned;


	// Use this for initialization
	void Start () {
        initialSpawnTime = Time.timeSinceLevelLoad;
        cooldownTime = 0f;
        spawned = false;
        randomizedSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        finalSpawnIncrease = spawnIncreaseOverTime * LevelData.GetNumDestroyed();
    }

    // Update is called once per frame
    private void Update()
    {
        if (minSpawnInterval - finalSpawnIncrease > minimumCapInterval)
        {
            finalSpawnIncrease = spawnIncreaseOverTime * LevelData.GetNumDestroyed();
        }
        if (cooldownTime > randomizedSpawnInterval && !spawned)
        {
            spawned = true;
            Spawn();
            cooldownTime = 0f;
            initialSpawnTime = Time.timeSinceLevelLoad;
            randomizedSpawnInterval = Random.Range(minSpawnInterval - finalSpawnIncrease, maxSpawnInterval - finalSpawnIncrease);
            Debug.Log(finalSpawnIncrease);
        }
        cooldownTime = Time.timeSinceLevelLoad - initialSpawnTime;
    }

    void Spawn()
    {
        if (Time.timeScale == 0)
        { 
        }
        else
        {
            Instantiate(ufo, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
        spawned = false;
    }
}
