using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseMenu : MonoBehaviour
{
    public Button restartButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        Button restartBtn = restartButton.GetComponent<Button>();
        restartBtn.onClick.AddListener(RestartGame);

        Button quitBtn = quitButton.GetComponent<Button>();
        quitBtn.onClick.AddListener(QuitGame);
    }

    void RestartGame()
    {
        // reload the current scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    void QuitGame()
    {
        // quit the application
        Application.Quit();
    }
}
