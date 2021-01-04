using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    public GameObject scoreText;
    private int iHighScore;


    void Start()
    {
        iHighScore = PlayerPrefs.GetInt("HighScore") > 0 ? PlayerPrefs.GetInt("HighScore") : 0;
        scoreText.GetComponent<Text>().text = "High-Score: " + iHighScore.ToString();
    }
}
