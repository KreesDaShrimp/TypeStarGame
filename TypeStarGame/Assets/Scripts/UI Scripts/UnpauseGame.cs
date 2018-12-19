using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UnpauseGame : MonoBehaviour
{

    public Button button;

    // Use this for initialization
    void Start()
    {
        //sets up button to work with a button object in game
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    //what to do when clicked
    void TaskOnClick()
    {
        Time.timeScale = 1.0f;
        
    }
   

}
