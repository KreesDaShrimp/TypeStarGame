using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spa : MonoBehaviour {

    public Transform ufo;

    public int SpawnRate = 1;
    public int IntialSpawnRate = 1;

	// Use this for initialization
	void Start () {

        InvokeRepeating("spawn", IntialSpawnRate, SpawnRate);
		
	}

    // Update is called once per frame

    void spawn()
    {
        if (Time.timeScale == 0)
        {

            
        }
        else
        {
            Instantiate(ufo, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            
        }
       

    }


}
