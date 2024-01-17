using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Elevators : MonoBehaviour
{
    void Update()
    {
        GetTouchingParts();
    }

    void GetTouchingParts()
    {
        foreach(Transform elevator in transform)
        {
            // get touching gameObjects
            Collider[] touching = Physics.OverlapBox(elevator.position, elevator.localScale / 2, elevator.rotation);
            
            // chech to see if any of the game objects are the player
            foreach(Collider hit in touching)
            {
                if(hit.tag == "Player")
                {
                    Elevate(hit);
                }
            }
        }
    }

    void Elevate(Collider player)
    {
        player.GetComponent<Rigidbody>().velocity = new Vector3(0,1,0);
        //'player.transform.Translate(0, Time.deltaTime, 0);
    }
}
