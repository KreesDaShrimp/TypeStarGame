using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWord : MonoBehaviour
{
    [Header("Game Objects")]
    public Text ScoreText;

    [Header("Audio")]
    public AudioSource UFOExplosion;
    public AudioSource Typing;
    public AudioSource BadSelect;
    
    private Color typingColor = new Color(0.4f, 0.8f, 1.0f);

    private int currentLevel;

    List<GameObject> ufoList = new List<GameObject>();

    private char typedLetter;
    private GameObject activeWord;
    private bool wordActivated;

    private int level1Score = 10;
    private int level2Score = 15;
    private int level3Score = 20;
    private int level4Score = 25;
    private int score;

    private void Start()
    {
        currentLevel = LevelData.GetLevel();
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

        // word activated only when the first letter of word is found
        if (wordActivated)
        {
            Text currentText = activeWord.GetComponentInChildren<Text>();
            string currentString = currentText.text;

            // set word color to active
            
            if (currentString[0] == typedLetter)
            {
                currentText.color = typingColor;
                Typing.Play();
                currentString = currentString.Remove(0, 1);
                currentText.text = currentString;
                typedLetter = ' ';
            }
            
            if (activeWord.GetComponentInChildren<Text>().text.Length == 1)
            {
                DestroyUFO(activeWord);
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

    // destroyes ufo and removes it from the list of ufos
    public void DestroyUFO(GameObject ufoToDestroy)
    {
        ufoToDestroy.SetActive(false);
        ufoList.Remove(ufoToDestroy);
        Destroy(ufoToDestroy);
        wordActivated = false;

        AddScore();
        UFOExplosion.Play();
        //Debug.Log(GetScore());
    }
    private void AddScore()
    {
        int incrementScore = 0;

        // score increment based on level
        if (currentLevel == 1)
        {
            incrementScore = level1Score;
        }

        else if (currentLevel == 2)
        {
            incrementScore = level2Score;
        }
        else if (currentLevel == 3)
        {
            incrementScore = level3Score;
        }
        else
        {
            incrementScore = level4Score;
        }

        // update score on canvas
        score = score + incrementScore;
        LevelData.IncrementNumDestroyed();
        LevelData.SetScore(score);
        ScoreText.text = "Score: " + score.ToString();
    }

    // returns current score
    public int GetScore()
    {
        return score;
    }
    public void SetWordActivatedFalse()
    {
        wordActivated = false;
    }
}