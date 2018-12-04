using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWord : MonoBehaviour
{

    public WordGenerator wordGenerator;
    private bool activeWord;
    private char activeLetter;
    private string theWord;
    private int currentIndex;

    public Text text;

    private void Start()
    {
        currentIndex = 0;
        text.text = wordGenerator.displayedText;
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
        foreach(char letter in Input.inputString)
        {
            Typing(letter);
            Debug.Log(letter);
        }
    }


}
