using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBoop : MonoBehaviour {

    public AudioSource Typing;
    public AudioSource BadSelect;

    public void Boop ()
    {
        Typing.Play();
    }

    public void BadBoop ()
    {
        BadSelect.Play();
    }
}
