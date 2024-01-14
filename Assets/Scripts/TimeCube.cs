using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCube : MonoBehaviour
{
    int lastRenderedSecond = 0; // the last second that the time was updated

    // update every frame
    private void Update() 
    {
        // if the currend time is passed the last rendeded second
        if (Math.Floor(Time.time) > lastRenderedSecond)
        {
            // bring the seconds up by one
            lastRenderedSecond++;

            // tick the cube
            TickCube();
        }
    }

    void TickCube() 
    {
        if(lastRenderedSecond%2 == 1)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        } 
        else 
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}
