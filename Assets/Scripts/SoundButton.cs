using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Button soundButton;
    public Sprite soundOn;
    public Sprite soundOff;

    public void Start(){
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            soundButton.GetComponent<Image>().sprite = soundOff;
        }
        else
        {
            soundButton.GetComponent<Image>().sprite = soundOn;
        }
    }

    public void doChangeSoundImage()
    {
        if (soundButton.GetComponent<Image>().sprite == soundOn)
        {
            soundButton.GetComponent<Image>().sprite = soundOff;
            PlayerPrefs.SetInt("Sound", 1);
        }
        else
        {
            soundButton.GetComponent<Image>().sprite = soundOn;
            PlayerPrefs.SetInt("Sound", 0);
        }
    }
}
