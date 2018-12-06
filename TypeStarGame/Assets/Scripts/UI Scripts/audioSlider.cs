using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class audioSlider : MonoBehaviour {

    public AudioMixer masterMixer;
    public Slider audSlider;

    private void Update()
    {
        if(audSlider.name == "Sldr_Music")
        {
            audSlider.onValueChanged.AddListener(delegate { SetMusicLevel(audSlider.value); });
        }
        if(audSlider.name == "Sldr_SFX")
        {
            audSlider.onValueChanged.AddListener(delegate { SetSFXLevel(audSlider.value); });
        }
    }
    public void SetSFXLevel(float sfxLevel)
    {
        masterMixer.SetFloat("SFX", sfxLevel);
    }
    public void SetMusicLevel(float musicLevel)
    {
        masterMixer.SetFloat("Music", musicLevel);
    }
   
}
