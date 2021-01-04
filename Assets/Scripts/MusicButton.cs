using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicButton : MonoBehaviour
{

    public Button musicButton;
    public Sprite musicOn;
    public Sprite musicOff;
    public AudioSource audioHome;

    public void Start()
    {
        if (PlayerPrefs.GetInt("Music") == 1)
        {
            musicButton.GetComponent<Image>().sprite = musicOff;
            audioHome.mute = true;
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicOn;
            audioHome.mute = false;
        }
    }

    public void doChangeImageMusic()
    {
        if (musicButton.GetComponent<Image>().sprite == musicOn)
        {
            musicButton.GetComponent<Image>().sprite = musicOff;
            audioHome.mute = true;
            PlayerPrefs.SetInt("Music", 1);
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicOn;
            audioHome.mute = false;
            PlayerPrefs.SetInt("Music", 0);
        }
    }
}
