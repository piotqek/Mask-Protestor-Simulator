using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour
{
    public GameObject currentScoreText;

    private int highScore =0;
    private int currentScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        SetCountText();
    }

    public void UpdateHighScoreAfterGameOver()
    {
        currentScore = currentScoreText.GetComponent<CounterController>().WhatsTheScore();
        if (currentScore > highScore) highScore = currentScore;
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
        SetCountText();
    }

    void SetCountText()
    {
       gameObject.GetComponent<Text>().text  = "High Score: " + highScore.ToString();
    }

}
//naprawic czytanie highscora