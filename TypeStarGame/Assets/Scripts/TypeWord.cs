using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWord : MonoBehaviour
{
    public Text ScoreText;
    public LevelHandler LevelHandler;
    public AudioSource UFOExplosion;
    public AudioSource Typing;
    public AudioSource BadSelect;

    private Color defaultColor = Color.white;
    private Color typingColor = new Color(0.4f, 0.8f, 1.0f);
    private Color wrongColor = Color.red;

    private int currentLevel;

    List<GameObject> ufoList = new List<GameObject>();

    private char typedLetter;
    private GameObject activeWord;
    private bool wordActivated;

    private int level1Score = 10;
    private int level2Score = 25;
    private int level3Score = 50;
    private int score;

    private void Start()
    {
        currentLevel = LevelHandler.CurrentLevel();
        wordActivated = false;
    }

    private void Update()
    {
        // detect letter typed
        foreach (char letter in Input.inputString)
        {
            //Debug.Log(letter);
            typedLetter = letter;
        }
        
        // check if there are any ufo objects on screen
        if (ufoList.Count > 0)
        {
            // iterate through the whole list of ufo objects
            for (int i = 0; i < ufoList.Count; i++)
            {
                if (ufoList[i] != null)
                {
                    // obtain text from the current ufo object in array
                    Text currentText = ufoList[i].GetComponentInChildren<Text>();
                    if (currentText != null)
                    {
                        if (currentText.text == "")
                        {
                            DestroyUFO(ufoList[i]);
                        }
                        else
                        {
                            string currentString = currentText.text;

                            if (currentString[0] == typedLetter && !wordActivated)
                            {
                                activeWord = ufoList[i];
                                wordActivated = true;
                            }
                        }
                    }
                }
            }
        }

        if (wordActivated)
        {
            Text currentText = activeWord.GetComponentInChildren<Text>();
            string currentString = currentText.text;

            currentText.color = typingColor;

            //Debug.Log(currentString);
            if (currentString[0] == typedLetter)
            {
                Typing.Play();
                currentString = currentString.Remove(0, 1);
                currentText.text = currentString;
                typedLetter = ' ';
            }
        }
    }
    
    // adds UFO object to list
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UFO")
        {
            ufoList.Add(collision.gameObject);
        }
    }
    public void DestroyUFO(GameObject ufoToDestroy)
    {
        ufoToDestroy.SetActive(false);
        ufoList.Remove(ufoToDestroy);
        Destroy(ufoToDestroy.transform.parent.gameObject);
        wordActivated = false;

        AddScore();
        UFOExplosion.Play();
        Debug.Log(GetScore());
    }
    private void AddScore()
    {
        int incrementScore = 0;
        if (currentLevel == 1)
        {
            incrementScore = level1Score;
        }
        else if (currentLevel == 2)
        {
            incrementScore = level2Score;
        }
        else
        {
            incrementScore = level3Score;
        }
        score = score + incrementScore;
        ScoreText.text = "Score: " + score.ToString();
    }
    public int GetScore()
    {
        return score;
    }
}