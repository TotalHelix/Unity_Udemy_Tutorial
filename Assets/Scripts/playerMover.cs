using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    // changes how fast the player accelerates
    [SerializeField] float weight = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        float x_velocity = Input.GetAxis("Horizontal") * weight;
        float z_velocity = Input.GetAxis("Vertical") * weight;

        transform.Translate(x_velocity, 0f, z_velocity);
    }
}
