using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class objectHit : MonoBehaviour
{
    Dictionary<GameObject, float> waitingParts = new();

    private void Update()
    {
        ResetOldMaterials();
    }

    // when the player hits something
    private void OnCollisionEnter(Collision other) 
    {
        // if the hit object is a part of terrain
        if (other.gameObject.GetComponent<Transform>().parent.name == "Terrain")
        {
            ChangeHitColor(other.gameObject);
            WaitForHit(other.gameObject);
        }
    }

    // change old materials back after bump
    void ResetOldMaterials()
    {
        foreach(KeyValuePair<GameObject, float> wall in waitingParts)
        {
            if(Time.time > wall.Value) 
            {
                wall.Key.GetComponent<MeshRenderer>().material.color = Color.white;
            }
        }
    }

    // change the color of the hit object
    void ChangeHitColor(GameObject hit) 
    {
        hit.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void WaitForHit(GameObject hit)
    {
        float release_time = Time.time + 0.1f;

        if(waitingParts.ContainsKey(hit)) {
            waitingParts[hit] = release_time;
        } else {
            waitingParts.Add(hit, release_time);
        }
    }
}
