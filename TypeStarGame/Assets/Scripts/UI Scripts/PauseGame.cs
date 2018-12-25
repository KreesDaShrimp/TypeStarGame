using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseGame : MonoBehaviour
{

    public Button button;
    public GameObject pannel;


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
        Time.timeScale = 0.0f;
        pannel.SetActive(true);
        button.gameObject.SetActive(false);
        LevelData.SetPaused(true);
    }
}
