using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnBehavior : MonoBehaviour {
    
    public float speed;
    public float speedIncrease;
    private float finalSpeedIncrease;
    private int numDestroyed;

	// Use this for initialization
	void Start ()
    {
        numDestroyed = LevelData.GetNumDestroyed();
        finalSpeedIncrease = speedIncrease * numDestroyed;
        //Debug.Log(finalSpeedIncrease);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if(!LevelData.GetPaused())
        {
            transform.position = new Vector2(transform.position.x - (speed + finalSpeedIncrease), transform.position.y);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //Debug.Log("Collision destroyed " + coll.gameObject + " after hitting " + coll.gameObject.name);
            Destroy(gameObject);
        }
    }
}
