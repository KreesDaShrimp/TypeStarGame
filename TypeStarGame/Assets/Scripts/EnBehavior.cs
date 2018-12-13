using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnBehavior : MonoBehaviour {


    public float speed = .1f;

	// Use this for initialization
	void Start () {

        if (Time.timeScale == 0)
        {

            print("Start in == 0");
        }
        else
        {
            print("Start out == 0");
        }
    }
	
	// Update is called once per frame
	void Update () {

        if(Time.timeScale == 0)
        {
            
            print("Update in == 0");
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
            print("Update out == 0");
        }

       
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Collision destroyed " + coll.gameObject + " after hitting " + coll.gameObject.name);
            Destroy(gameObject);
        }
    }
}
