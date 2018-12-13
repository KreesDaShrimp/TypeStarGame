using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextReader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public TextAsset TextFile;
    void readTextFileLines()
    {
        string[] linesInFile = TextFile.text.Split('\n');
        foreach (string line in linesInFile)
        {
            Debug.Log(line);
        }
    }
}
