using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPoint : MonoBehaviour
{
    // if the player collides with the win point and have more than goal points, the game is won and show the win screen UI element and hide the game UI element and hide the player object
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().score >= GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().goalPoints)
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().gameWon = true;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().winScreenUI.SetActive(true);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().gameUI.SetActive(false);
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
        }
    }
}
