using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    // changes how fast the player moves
    float speed = 5.71f;

    // Update is called once per frame
    void Update() 
    {
        movePlayer();
    }

    void movePlayer()
    {
        float x_velocity = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z_velocity = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(x_velocity, 0f, z_velocity);
    }
}
