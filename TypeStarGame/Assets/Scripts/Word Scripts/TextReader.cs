using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TextReader : MonoBehaviour {

    public TextAsset level1List;
    public TextAsset level2List;
    public TextAsset level3List;
    public TextAsset level4List;

    private List<string> levelWords = new List<string>();

    private int currentLevel;

    private bool levelAdvanced = false;
    private bool debugList = false;

    // Use this for initialization
    void Start ()
    {
        currentLevel = LevelData.GetLevel();

        if (currentLevel == 1)
        {
            ReadLinesFromFile(level1List);
        }
        else if (currentLevel == 2)
        {
            ReadLinesFromFile(level2List);
        }
        else if (currentLevel == 3)
        {
            ReadLinesFromFile(level3List);
        }
        else
        {
            ReadLinesFromFile(level4List);
        }
    }

	void ReadLinesFromFile(TextAsset currentList)
    {
        string[] linesInFile = currentList.text.Split('\n');
        foreach (string line in linesInFile)
        {
            if (line != "")
            {
                //Debug.Log(line);
                levelWords.Add(line);
            }
        }
        levelAdvanced = false;
    }


    public List<string> GetWordList()
    {
        return levelWords;
    }

    public string GetRandomWord()
    {
        levelWords.TrimExcess();
        int randomIndex = Random.Range(0, levelWords.Count);
        string randomString = levelWords[randomIndex];
        levelWords.RemoveAt(randomIndex);
        levelWords.TrimExcess();

        //Debug.Log("Word Size List: " + levelWords.Count);

        return randomString;
    }

	// Update is called once per frame
	void Update () {
        if (levelWords.Count < 1)
        {
            if (currentLevel < 4 && !levelAdvanced)
            {
                currentLevel++;
                levelAdvanced = true;
            }

            if (currentLevel == 2)
            {
                ReadLinesFromFile(level2List);
            }
            if (currentLevel == 3)
            {
                ReadLinesFromFile(level3List);
            }
            if (currentLevel == 4)
            {
                ReadLinesFromFile(level4List);
            }
        }

        /*
        Debug.Log(levelWords.Count);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            debugList = true;
        }
        if (debugList)
        {
            while (levelWords.Count > 3)
            {
                levelWords.RemoveAt(0);
            }
            if (levelWords.Count <= 3)
            {
                debugList = false;
            }
        }
        */
    }
}
