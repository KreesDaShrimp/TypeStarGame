using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class audioSlider : MonoBehaviour {

    public AudioMixer masterMixer;
    
    public void SetSFXLevel(float sfxLevel)
    {
        masterMixer.SetFloat("SFX", sfxLevel);
    }
    public void SetMusicLevel(float musicLevel)
    {
        masterMixer.SetFloat("Music", musicLevel);
    }
   
}
