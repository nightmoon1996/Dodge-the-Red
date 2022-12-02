using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HighScore : MonoBehaviour
{
    // show high time score on high score UI element text and player can enter their name to save their high score using unity engine UI
    public TMP_InputField nameInput;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI highScoreNameText;
    public TextMeshProUGUI highScoreTimeText;

    // Start is called before the first frame update
    void Start()
    {
        // if the high score is not 0, show the high score UI element text and set the high score UI element text to the high score
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreText.gameObject.SetActive(true);
            highScoreText.text = "High Score: " + PlayerPrefs.GetFloat("HighScore").ToString("F2");
            highScoreNameText.text = "Name: " + PlayerPrefs.GetString("HighScoreName");
            highScoreTimeText.text = "Time: " + PlayerPrefs.GetFloat("HighScoreTime").ToString("F2");
        }
    }

    // save the high score and high score name to player prefs
    public void SaveHighScore()
    {
        PlayerPrefs.SetFloat("HighScore", PlayerPrefs.GetFloat("HighScoreTime"));
        PlayerPrefs.SetString("HighScoreName", nameInput.text);
    }

    // reset the high score and high score name in player prefs
    public void ResetHighScore()
    {
        PlayerPrefs.SetFloat("HighScore", 0);
        PlayerPrefs.SetString("HighScoreName", "");
        highScoreText.gameObject.SetActive(false);
    }

    // if the high score is 0, show the high score UI element text and set the high score UI element text to the high score
    public void ShowHighScore()
    {
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreText.gameObject.SetActive(true);
            highScoreText.text = "High Score: " + PlayerPrefs.GetFloat("HighScore").ToString("F2");
            highScoreNameText.text = "Name: " + PlayerPrefs.GetString("HighScoreName");
            highScoreTimeText.text = "Time: " + PlayerPrefs.GetFloat("HighScoreTime").ToString("F2");
        }
    }

    // if the high score is not 0, hide the high score UI element text
    public void HideHighScore()
    {
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreText.gameObject.SetActive(false);
        }
    }

    // if the high score is not 0, show the high score UI element text and set the high score UI element text to the high score
    public void ShowHighScoreName()
    {
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreNameText.gameObject.SetActive(true);
            highScoreNameText.text = "Name: " + PlayerPrefs.GetString("HighScoreName");
        }
    }

    // if the high score is not 0, hide the high score UI element text
    public void HideHighScoreName()
    {
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreNameText.gameObject.SetActive(false);
        }
    }

    // if the high score is not 0, show the high score UI element text and set the high score UI element text to the high score
    public void ShowHighScoreTime()
    {
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreTimeText.gameObject.SetActive(true);
            highScoreTimeText.text = "Time: " + PlayerPrefs.GetFloat("HighScoreTime").ToString("F2");
        }
    }

    // if the high score is not 0, hide the high score UI element text
    public void HideHighScoreTime()
    {
        if (PlayerPrefs.GetFloat("HighScore") != 0)
        {
            highScoreTimeText.gameObject.SetActive(false);
        }
    }
}
