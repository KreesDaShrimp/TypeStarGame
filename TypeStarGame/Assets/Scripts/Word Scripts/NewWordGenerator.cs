using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewWordGenerator : MonoBehaviour {
    
    private string displayedText;
    private Text textBox;

    // Use this for initialization
    void Start () {
        textBox = GetComponent<Text>();
        displayedText = GameObject.Find("Dictionary").GetComponent<TextReader>().GetRandomWord();
        textBox.text = displayedText;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
