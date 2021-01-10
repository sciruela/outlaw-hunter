using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class CowboysSpawner : MonoBehaviour
{
    private int iRandomCowboy;
    public Sprite[] aCowboys;
    public GameObject parentPanel;
    public GameObject scoreText;
    private GameObject spriteCowboy;
    private int iScoreCounter;
    private int iPositionx, iPositiony;
    private float timeLeft;
    private int iCowboys;
    private EventSystem oEventSystem;
    private int iScore;



    void Start()
    {
        iScoreCounter = 0;
        iCowboys = 1 ;
        scoreText.GetComponent<Text>().text = "SCORE: " + getScore().ToString();
        InvokeRepeating("doCreateCowboy", 0.0f, 3.0f);
    }
    void Update()
    {

    }

    int getScore()
    {
        return iScoreCounter++; 
    }


    void doButtonClicked() {

        oEventSystem = EventSystem.current;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            AudioClip oAudioBang1 = Resources.Load<AudioClip>("Audio/bang1");

            AudioSource oAudioSource = new GameObject().AddComponent<AudioSource>();
            oAudioSource.name = "Bang";
            oAudioSource.clip = oAudioBang1;

            if (PlayerPrefs.GetInt("Sound") == 1){
                oAudioSource.volume = 0;
            } else {
                oAudioSource.volume = 1;
            }
                
            oAudioSource.Play();
            oAudioSource.transform.parent = null;
            Destroy(oAudioSource.gameObject, 1);

            iScore = getScore();

            scoreText.GetComponent<Text>().text = "SCORE: " + iScore.ToString();

            if (iScore > PlayerPrefs.GetInt("HighScore")) PlayerPrefs.SetInt("HighScore", iScore);


            spriteCowboy = GameObject.Find(oEventSystem.currentSelectedGameObject.name);
            spriteCowboy.SetActive(false);
            Destroy(spriteCowboy);


        }
    }

    void doCreateCowboy()
    {
        iRandomCowboy = UnityEngine.Random.Range(0, aCowboys.Length);
        GetComponent<Image>().sprite = aCowboys[iRandomCowboy];
        GetComponent<Image>().enabled = true;

        spriteCowboy = new GameObject();
        spriteCowboy.name = "CowboyImage"+iCowboys;
        Image newImage = spriteCowboy.AddComponent<Image>();
        CowboyScript oCowboyScript = spriteCowboy.AddComponent<CowboyScript>();
        GameObject newGameObject = newImage.gameObject;
        Button imageButton = newGameObject.AddComponent<Button>();

        imageButton.onClick.AddListener(delegate { doButtonClicked(); });
        newImage.sprite = aCowboys[iRandomCowboy];
        spriteCowboy.GetComponent<RectTransform>().SetParent(parentPanel.transform);
        spriteCowboy.SetActive(true);
      
        iPositionx = UnityEngine.Random.Range(100, 2000);
        iPositiony = UnityEngine.Random.Range(100, 200);

        spriteCowboy.GetComponent<RectTransform>().position = new Vector3(iPositionx, iPositiony, 0);
        AudioClip oAudioWhistle1 = Resources.Load<AudioClip>("Audio/whistle1");

        AudioSource oAudioSource = new GameObject().AddComponent<AudioSource>();
        oAudioSource.name = "Whistle";
        oAudioSource.clip = oAudioWhistle1;

        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            oAudioSource.volume = 0;
        }
        else
        {
            oAudioSource.volume = 1;
        }

        oAudioSource.Play();
        oAudioSource.transform.parent = null;
        Destroy(oAudioSource.gameObject, 1);

        iCowboys++;

    }

}
