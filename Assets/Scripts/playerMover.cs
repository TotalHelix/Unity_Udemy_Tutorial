using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMover : MonoBehaviour
{
    // changes how fast the player accelerates
    [SerializeField] float weight = 5.71f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am working");
        // transform.Translate(0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        float x_velocity = Input.GetAxis("Horizontal") * weight * Time.deltaTime;
        float z_velocity = Input.GetAxis("Vertical") * weight * Time.deltaTime;

        transform.Translate(x_velocity, 0f, z_velocity);
    }
}
