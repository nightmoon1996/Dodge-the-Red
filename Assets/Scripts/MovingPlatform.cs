using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
     // move platform back by 0.1 units every frame on the z axis  
        transform.Translate(Vector3.back * 0.1f); 

        // reset position of platform to 0,0,0 if it goes past -10 on the z axis
        if (transform.position.z < -10)
        {
            transform.position = new Vector3(-3.112995f, 3.9f, 53.9f);
        }

    }

}
