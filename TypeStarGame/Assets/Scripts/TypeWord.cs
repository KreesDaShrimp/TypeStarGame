using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWord : MonoBehaviour
{
    private bool activeWord;
    private char activeLetter;
    private string theWord;
    private int currentIndex;

    private Color defaultColor = Color.white;
    private Color typingColor = new Color(0.4f, 0.8f, 1.0f);
    private Color wrongColor = Color.red;

    List<GameObject> ufoList = new List<GameObject>();

    private char typedLetter;

    private void Start()
    {
        currentIndex = 0;
        // text.text = wordGenerator.displayedText;
    }
    public void Typing(char letter)
    {
        /*
        if(letter == wordGenerator.displayedText[0])
        {
            //text.color = Color.green;
        }
        else
        {
            //text.color = Color.red;
        }
        */
        currentIndex++;
    }

    private void Update()
    {
        // detect letter typed
        foreach (char letter in Input.inputString)
        {
            Typing(letter);
            Debug.Log(letter);
            typedLetter = letter;
        }
        

        Debug.Log(ufoList.Count);
        if (ufoList.Count > 0)
        {
            // ufoList[0].GetComponentInChildren<Text>().color = typingColor;
            for (int i = 0; i < ufoList.Count; i++)
            {
                Text currentText = ufoList[i].GetComponentInChildren<Text>();

                if (currentText.text.Length < 1)
                {
                    ufoList[i].SetActive(false);
                    ufoList.Remove(ufoList[i]);
                }
                else
                {
                    string currentString = currentText.text;

                    if (currentString[0] == typedLetter)
                    {
                        currentText.color = typingColor;
                        currentString = currentString.Remove(0, 1);
                        Debug.Log(currentString);
                        currentText.text = currentString;
                    }
                }
            }
        }
    }
    
    // adds UFO object to list
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ufoList.Add(collision.gameObject);
    }
}