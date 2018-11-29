using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnBehavior : MonoBehaviour {


    public float speed = .1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector2(transform.position.x - speed,transform.position.y);
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

        Destroy(gameObject);
        

    }
}
