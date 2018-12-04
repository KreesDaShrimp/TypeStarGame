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

    List<GameObject> ufoList = new List<GameObject>();

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
        foreach (char letter in Input.inputString)
        {
            Typing(letter);
            Debug.Log(letter);
        }
        Debug.Log(ufoList.Count);
        if (ufoList.Count > 0)
        {
            ufoList[0].GetComponentInChildren<Text>().color = new Color(0.4f, 0.8f, 1.0f);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hi");
        ufoList.Add(collision.gameObject);
    }
}