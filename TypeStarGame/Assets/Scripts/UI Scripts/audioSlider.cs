using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class audioSlider : MonoBehaviour {

    public Slider slider;
    private GameObject audioObject;
    private AudioSource audio;
    private float startVal;
    private float currentVal;

    // Use this for initialization
    void Start () {
        audioObject = GameObject.FindGameObjectWithTag("music");
        audio = audioObject.GetComponent<AudioSource>();
        slider.value = audio.volume*100;
        startVal = slider.value;
		
	}

	
	// Update is called once per frame
	void Update () {
        currentVal = slider.value;
        if(startVal != currentVal)
        {
            startVal = currentVal;
            audio.volume = startVal / 100;
        }
		
	}
    
}
