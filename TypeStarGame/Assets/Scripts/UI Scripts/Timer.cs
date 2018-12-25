using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float currentTime;
    private int printedTime;
    private Text textObject;
    private string text;

    private float timeAtPaused;
	// Use this for initialization
	void Start () {
        currentTime = 0;
        printedTime = (int)currentTime;
        textObject = GetComponent<Text>();
        text = "Time: " + printedTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
    private void FixedUpdate()
    {
        if (!LevelData.GetPaused())
        {
            currentTime += Time.deltaTime;
            printedTime = (int)currentTime;
            text = "Time: " + printedTime;
            textObject.text = text;
            LevelData.SetTime(printedTime);
        }
    }
}
