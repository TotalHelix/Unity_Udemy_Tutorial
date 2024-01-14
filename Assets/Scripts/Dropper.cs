using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    // what time the falling things fall
    readonly float dropTime = 2f;
    void Update()
    {
        if(Time.time > dropTime) 
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
