using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour {

    private int lives = 3;

    GameObject li;
    GameObject li1;
    GameObject li2;
  

    // Use this for initialization
    void Start () {

        li = GameObject.FindWithTag("Life3");

        li1 = GameObject.FindWithTag("Life2");

        li2 = GameObject.FindWithTag("Life1");
		
	}
	
	// Update is called once per frame
	void Update () {

        Dest();
    
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

        lives--;

        
    }

    void Dest(){

        if (lives == 2)
        {
            Destroy(li);

        }

        if (lives == 1)
        {
            Destroy(li1);

        }

        if (lives == 0)
        {

            Destroy(li2);

            SceneManager.LoadScene("Game Over");

        }


    }

}
