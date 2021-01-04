using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soundutton : MonoBehaviour
{
    public Button soundButton;
    public Sprite soundOn;
    public Sprite soundOff;

    public void Start()
    {
        if (PlayerPrefs.GetInt("Audio") == 1)
        {
            soundButton.GetComponent<Image>().sprite = soundOff;
        }
        else
        {
            soundButton.GetComponent<Image>().sprite = soundOn;
        }
    }

    public void doChangeSoundMusic()
    {
        if (soundButton.GetComponent<Image>().sprite == soundOn)
        {
            soundButton.GetComponent<Image>().sprite = soundOff;
        }
        else
        {
            soundButton.GetComponent<Image>().sprite = soundOn;
        }
    }
}
