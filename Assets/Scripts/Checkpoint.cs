using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // on player collision with checkpoint with tag "Checkpoint" set respawn point to checkpoint position
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().respawnPoint = transform.position;
            // Destroy(gameObject);
        }
    }
}
