using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    // changes how fast the player moves
    float speed = 300;

    // Update is called once per frame
    void Update() 
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float x_velocity = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float z_velocity = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        GetComponent<Rigidbody>().velocity = new Vector3(x_velocity, GetComponent<Rigidbody>().velocity.y, z_velocity);
    }
}
