using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBlock : MonoBehaviour
{
    float timePassed = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // create new dead block inside floor parent at random position on moving platform area as game object set rotation to 0,90,0 and scale to 0.004781657, 1 ,0.1218104
        if (GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().gameStarted == true && GameObject.FindGameObjectsWithTag("DeadBlock").Length < 25)
        {
            Instantiate(gameObject, new Vector3(Random.Range(-12.5f, 9f), 5, Random.Range(100, 200)), Quaternion.identity);
        }

        // increase block speed
        timePassed += Time.deltaTime;
        if(timePassed > 5f)
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().blockSpeed += 0.05f;
            timePassed = 0f;
        } 
        // move block backward at block speed
        transform.Translate(Vector3.back * GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().blockSpeed * Time.deltaTime);

        // destroy dead block if it passed the player 
        if (transform.position.z < -6)
        {
            Destroy(gameObject);
        }
    }
    // if player collides with the dead block, move player to respawn position from gamemanager and remove 1 life from gamemanager
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().respawnPoint;
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().lives -= 1;
        }
    }


}
