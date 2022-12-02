using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // spin the coin
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }

    // when player collide with coin object with tag "Coin" destroy it and add 1 score to gamemanager
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().score += 1;
        }
    }
}
