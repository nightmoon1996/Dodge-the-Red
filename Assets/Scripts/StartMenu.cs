using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    // start menu UI elements and buttons to start the game and quit the game
    public Button startButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button startBtn = startButton.GetComponent<Button>();
        startBtn.onClick.AddListener(StartGame);

        Button quitBtn = quitButton.GetComponent<Button>();
        quitBtn.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartGame()
    {
        // load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    void QuitGame()
    {
        // quit the application
        Application.Quit();
    }
}
