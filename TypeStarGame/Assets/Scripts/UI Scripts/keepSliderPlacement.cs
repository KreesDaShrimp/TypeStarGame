using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class keepSliderPlacement : MonoBehaviour {

    public Slider slider;
    public AudioMixer masterMixer;
    // Use this for initialization
    void Start () {
        float value;
        if(slider.name == "Sldr_Music")
        {
            bool result = masterMixer.GetFloat("Music", out value);
            if (result)
            {
                slider.value = value;
            }
            else
            {
                slider.value = 0f;
            }
        }
        if (slider.name == "Sldr_SFX")
        {
            bool result = masterMixer.GetFloat("SFX", out value);
            if (result)
            {
                slider.value = value;
            }
            else
            {
                slider.value = 0f;
            }
        }



    }
	
	// Update is called once per frame
	void Update () {
        
		
	}
}
