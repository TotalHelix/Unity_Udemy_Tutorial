using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        other.gameObject.GetComponent<MeshRenderer>().material = Resources.Load<Material>("hit_white");
    }

    void changeHitColor() 
    {

    }
}
