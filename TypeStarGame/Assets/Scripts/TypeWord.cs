using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWord : MonoBehaviour
{
    public Text ScoreText;
    public AudioSource UFOExplosion;

    private Color defaultColor = Color.white;
    private Color typingColor = new Color(0.4f, 0.8f, 1.0f);
    private Color wrongColor = Color.red;

    List<GameObject> ufoList = new List<GameObject>();

    private char typedLetter;
    private GameObject activeWord;
    private bool wordActivated;
    private int score;

    private void Start()
    {
        wordActivated = false;
    }

    private void Update()
    {
        // detect letter typed
        foreach (char letter in Input.inputString)
        {
            Debug.Log(letter);
            typedLetter = letter;
        }
        
        if (ufoList.Count > 0)
        {
            for (int i = 0; i < ufoList.Count; i++)
            {
                if (ufoList[i] != null)
                {
                    Text currentText = ufoList[i].GetComponentInChildren<Text>();
                    if (currentText.text.Length < 1)
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

        if (wordActivated)
        {
            Text currentText = activeWord.GetComponentInChildren<Text>();
            string currentString = currentText.text;

            currentText.color = typingColor;

            Debug.Log(currentString);
            if (currentString[0] == typedLetter)
            {
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
        Debug.Log("Destroyed " + ufoToDestroy);
        Destroy(ufoToDestroy);
        wordActivated = false;
        score = score + 50;
        ScoreText.text = "Score: " + score.ToString();
        UFOExplosion.Play();
        Debug.Log(GetScore());
    }
    public int GetScore()
    {
        return score;
    }
}