using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseKey : MonoBehaviour {

    public GameObject pausePanel;
    public GameObject pauseButtonPanel;
    public Button pauseButton;
    public Button unpauseButton;

	// Use this for initialization
	void Start () {
        pausePanel.SetActive(false);
        pauseButtonPanel.SetActive(true);

        unpauseButton.onClick.AddListener(TogglePause);
        pauseButton.onClick.AddListener(TogglePause);
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
	}
    void TogglePause()
    {
        if (LevelData.GetPaused())
        {
            Debug.Log("Game unPaused!");
            pausePanel.SetActive(false);
            pauseButtonPanel.SetActive(true);
            Time.timeScale = 1;
            LevelData.SetPaused(false);
        }
        else
        {
            Debug.Log("Game Paused!");
            pausePanel.SetActive(true);
            pauseButtonPanel.SetActive(false);
            Time.timeScale = 0;
            LevelData.SetPaused(true);
        }
    }
}
