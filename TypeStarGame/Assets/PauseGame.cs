using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseGame : MonoBehaviour
{

    public Button button;

    // Use this for initialization
    void Start()
    {
        //sets up button to work with a button object in game
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Time.timeScale = 0;
        Time.timeScale = 1;


    }

    //what to do when clicked
    void TaskOnClick()
    {
        Time.timeScale = 0;

        print(Time.timeScale);
    }
    // Update is called once per frame
    void Update()
    {
        //doesn't do anything
    }

}
