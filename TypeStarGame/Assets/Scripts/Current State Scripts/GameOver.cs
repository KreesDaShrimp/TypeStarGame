using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private void Start()
    {
    }
    void Update()
    {

        if (Input.GetKeyDown("space")) {

            LevelData.SetLevel(1);
            LevelData.SetNumDestroyed(0);
            LevelData.SetTime(0);
            LevelData.SetScore(0);
            LevelData.SetPaused(false);
            SceneManager.LoadScene("Main Menu");

        }
    }
}
