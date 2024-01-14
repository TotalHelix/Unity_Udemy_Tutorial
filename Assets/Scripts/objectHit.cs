using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class objectHit : MonoBehaviour
{
    readonly float colorChange = 0.2f; // how much the  color changes each time a wall is hit
    int score = 0; // how many things the player has hit

    // when the player hits something
    private void OnCollisionEnter(Collision other) 
    {
        ChangeHitColor(other.gameObject);
        AddScore();
    }

    // add one to the score
    void AddScore()
    {
        score++;
    }

    // change the color of the hit object
    void ChangeHitColor(GameObject hit) 
    {
        // get old rgb values
        Material old_material = hit.GetComponent<MeshRenderer>().material;
        float red = old_material.color.r;
        float green = old_material.color.g;
        float blue = old_material.color.b;
        
        //hit.GetComponent<MeshRenderer>().material = Resources.Load<Material>("hit_white");
        hit.GetComponent<MeshRenderer>().material.color = new Color(
            red+colorChange, 
            green-colorChange, 
            blue-colorChange
        );
    }
}
