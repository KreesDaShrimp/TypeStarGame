using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndStats : MonoBehaviour {

    public Text score;
    public Text ships;
    public Text time;

    // Use this for initialization
    void Start () {
        ships.text = "Ships Destroyed: " + LevelData.GetNumDestroyed();
        time.text = "Time Survived: " + LevelData.GetTime();
        score.text = "Final Score: " + LevelData.GetScore();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
