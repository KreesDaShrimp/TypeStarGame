using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class moveToNewScene : MonoBehaviour
{

    public Button button;
    public string nextRoom;

    public int setLevel;

    // Use this for initialization
    void Start()
    {
        //sets up button to work with a button object in game
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        //unpauses game if coming back from pause menu
        Time.timeScale = 1.0f;

    }

    //what to do when clicked
    void TaskOnClick()
    {
        LevelData.SetLevel(setLevel);
        SceneManager.LoadScene(nextRoom);

    }
    // Update is called once per frame
    void Update()
    {
        //doesn't do anything
    }

}
