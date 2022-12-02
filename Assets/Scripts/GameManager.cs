using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    public int goalPoints = 10;
    public Vector3 respawnPoint = new Vector3(-2.45f, 5.71f, -6.563826f);
    public bool gameWon = false;
    public bool gameLost = false;
    public bool gameStarted = true;
    public GameObject gameUI;
    public GameObject winScreenUI;
    public GameObject loseScreenUI;
    public GameObject timerUI;
    public float blockSpeed = 0.1f;
    public int blockSpeedIncrease = 1;
    public int blockSpeedIncreaseInterval = 10;
    // Start is called before the first frame update
    void Start()
    {
        // hide the win screen UI element and hide the lose screen UI element
        winScreenUI.SetActive(false);
        loseScreenUI.SetActive(false);
        gameUI.SetActive(true);
        timerUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        // if player has 0 lives, the game is lost and show the lose screen UI element and hide the game UI element and hide the player object
        if (lives == 0)
        {
            gameLost = true;
            loseScreenUI.SetActive(true);
            gameUI.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
        }

        // timer UI element text is set to the time since the game started in seconds as a string with 2 decimal places 
        timerUI.GetComponent<TextMeshProUGUI>().text = Time.timeSinceLevelLoad.ToString("F2");
    }
}
