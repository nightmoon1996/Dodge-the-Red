using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
/*        // get mouse input and move player left and right
        float mouseX = Input.GetAxis("Mouse X");
        transform.Translate(Vector3.right * mouseX * speed * Time.deltaTime);
*/


        // get the a s w d keys and move the player with force in the direction of vector 3
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
        }
/*
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back);
        } */

        // check if player fall down below vector y = -4
        if (transform.position.y < 2)
        {
            // if player fall down below vector y = -4, move player to respawn position from gamemanager
            transform.position = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().respawnPoint;

            // reset player velocity to 0 angular velocity to 0 and rotation to 0
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            
            // remove 1 life from gamemanager
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>().lives -= 1;
        }
    }
}
