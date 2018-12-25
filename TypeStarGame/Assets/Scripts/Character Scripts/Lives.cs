using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour {

    public AudioSource UFOExplosion;
    private GameObject canvasCollider;
    private TypeWord typeWordScript;
    private int lives = 3;

    GameObject li;
    GameObject li1;
    GameObject li2;
  

    // Use this for initialization
    void Start () {
        canvasCollider = GameObject.Find("Canvas Collider");
        typeWordScript = canvasCollider.GetComponent<TypeWord>();

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
        if (coll.gameObject.tag == "UFO")
        {
            //Debug.Log("Collided!");
            UFOExplosion.Play();
            lives--;
            typeWordScript.SetWordActivatedFalse();
        }
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
